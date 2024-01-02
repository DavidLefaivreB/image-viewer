using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ImageBrowser.Model;
using ImageBrowser.Notifier;
using ImageBrowser.Ui.Component;

namespace ImageBrowser.Ui.View.Gallery
{
    /// <summary>
    /// Interaction logic for CentralPanel.xaml
    /// </summary>
    public partial class CentralPanel : UserControl
    {
        public CentralPanel()
        {
            InitializeComponent();
        }
        
        public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(nameof(Source), typeof(List<Picture>), typeof(CentralPanel), new PropertyMetadata(new List<Picture>(), OnSourceChanged));

        public List<Picture> Source
        {
            get => (List<Picture>)GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var panel = d as CentralPanel;
            panel?.RefreshThumbnails(e.NewValue as List<Picture>);
        }

        private void RefreshThumbnails(List<Picture> pictures)
        {
            ThumbnailContainer.Clear();
            pictures.ForEach(AddThumbnail);
            ThumbnailContainer.Refresh();
        }
        
        private void AddThumbnail(Picture picture)
        {
            PictureThumbnail pictureThumbnail = new PictureThumbnail();
            pictureThumbnail.Picture = picture;

            ThumbnailContainer.AddThumbnail(pictureThumbnail);
        }
    }
}