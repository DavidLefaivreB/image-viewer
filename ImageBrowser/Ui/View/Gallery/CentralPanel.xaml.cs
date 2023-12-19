using System.Collections.Generic;
using System.Windows.Controls;
using ImageBrowser.Model;
using ImageBrowser.Notifier;
using ImageBrowser.Ui.Component;

namespace ImageBrowser.Ui
{
    /// <summary>
    /// Interaction logic for CentralPanel.xaml
    /// </summary>
    public partial class CentralPanel : UserControl, ThumbnailsListener
    {
        public CentralPanel()
        {
            InitializeComponent();
        }

        public void Notify(List<Picture> pictures)
        {
            thumbnailContainer.Clear();
            pictures.ForEach(AddThumbnail);
            thumbnailContainer.Refresh();
        }

        private void AddThumbnail(Picture picture)
        {
            PictureThumbnail pictureThumbnail = new PictureThumbnail();
            pictureThumbnail.Picture = picture;

            thumbnailContainer.AddThumbnail(pictureThumbnail);
        }
    }
}