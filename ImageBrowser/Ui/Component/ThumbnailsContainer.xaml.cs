using System;
using System.Collections.Generic;
using System.Windows;

namespace ImageBrowser.Ui.Component
{
    public partial class ThumbnailsContainer
    {
        private List<PictureThumbnail> _thumbnails = new List<PictureThumbnail>();

        private double CurrentWindowWidth { get; set; }

        public ThumbnailsContainer()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            _thumbnails.Clear();
        }

        public void AddThumbnail(PictureThumbnail thumbnail)
        {
            _thumbnails.Add(thumbnail);
        }

        public void Refresh()
        {
            if (CurrentWindowWidth > 0)
                RearrangeThumbnails();
        }

        private void OnControlSizeChanged(object sender, SizeChangedEventArgs e)
        {
            CurrentWindowWidth = GetContainerVisibleWidth(e);

            if (_thumbnails.Count > 0)
                RearrangeThumbnails();
        }

        private void RearrangeThumbnails()
        {
            Children.Clear();
            var nbThumbnailsByRow = (int)(CurrentWindowWidth / Constants.THUMBNAIL_WIDTH);

            for (var i = 0; i < _thumbnails.Count; i++)
            {
                DisplayThumbnail(i, nbThumbnailsByRow);
            }

            Height = Math.Ceiling((double)_thumbnails.Count / nbThumbnailsByRow) * Constants.THUMBNAIL_HEIGHT;
        }

        private void DisplayThumbnail(int thumbnailIndex, int nbThumbnailsByRow)
        {
            var rowIndex = thumbnailIndex / nbThumbnailsByRow;
            var columnIndex = thumbnailIndex - rowIndex * nbThumbnailsByRow;

            SetLeft(_thumbnails[thumbnailIndex], columnIndex * Constants.THUMBNAIL_WIDTH);
            SetTop(_thumbnails[thumbnailIndex], rowIndex * Constants.THUMBNAIL_HEIGHT);
            Children.Add(_thumbnails[thumbnailIndex]);
        }

        private static double GetContainerVisibleWidth(SizeChangedEventArgs e)
        {
            return e.NewSize.Width - SystemParameters.VerticalScrollBarWidth;
        }
    }
}