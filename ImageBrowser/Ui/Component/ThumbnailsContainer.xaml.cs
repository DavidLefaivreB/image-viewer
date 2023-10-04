using System;
using System.Collections.Generic;
using System.Windows;

namespace ImageBrowser.Ui.Component
{
    public partial class ThumbnailsContainer
    {
        private List<PictureThumbnail> thumbnails = new List<PictureThumbnail>();
        
        public ThumbnailsContainer()
        {
            InitializeComponent();
        }

        public void addThumbnail(PictureThumbnail thumbnail)
        {
            thumbnails.Add(thumbnail);
        }

        private void onControlSizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (thumbnails.Count > 0)
                RearrangeThumbnails(GetContainerVisibleWidth(e));
        }

        private void RearrangeThumbnails(double windowWidth)
        {
            Children.Clear();
            var nbThumbnailsByRow = (int) (windowWidth / Constants.THUMBNAIL_WIDTH);
            
            for (var i = 0; i < thumbnails.Count; i++)
            {
                DisplayThumbnail(i, nbThumbnailsByRow);
            }

            Height = Math.Ceiling((double)thumbnails.Count / nbThumbnailsByRow) * Constants.THUMBNAIL_HEIGHT;
        }

        private void DisplayThumbnail(int thumbnailIndex, int nbThumbnailsByRow)
        {
            var rowIndex = thumbnailIndex / nbThumbnailsByRow;
            var columnIndex = thumbnailIndex - rowIndex * nbThumbnailsByRow;

            SetLeft(thumbnails[thumbnailIndex], columnIndex * Constants.THUMBNAIL_WIDTH);
            SetTop(thumbnails[thumbnailIndex], rowIndex * Constants.THUMBNAIL_HEIGHT);
            Children.Add(thumbnails[thumbnailIndex]);
        }

        private static double GetContainerVisibleWidth(SizeChangedEventArgs e)
        {
            return e.NewSize.Width - SystemParameters.VerticalScrollBarWidth;
        }
    }
}