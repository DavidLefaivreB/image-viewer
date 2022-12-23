using ImageBrowser.Ui.Component;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ImageBrowser.Ui
{
    /// <summary>
    /// Interaction logic for CentralPanel.xaml
    /// </summary>
    public partial class CentralPanel : UserControl
    {
        public CentralPanel()
        {
            InitializeComponent();

            PictureThumbnail pictureThumbnail = new PictureThumbnail();
            pictureThumbnail.Path = @"D:\patreon\yupachu\april_2018\thumbnail\2b.jpg";
            pictureThumbnail.Description = "2b";

            Canvas.SetLeft(pictureThumbnail, 20);
            Canvas.SetTop(pictureThumbnail, 20);
            thumbnailContainer.Children.Add(pictureThumbnail);

            PictureThumbnail pictureThumbnail2 = new PictureThumbnail();
            pictureThumbnail2.Path = @"D:\patreon\yupachu\april_2018\thumbnail\faith.jpg";
            pictureThumbnail2.Description = "Faith";

            Canvas.SetLeft(pictureThumbnail2, 220);
            Canvas.SetTop(pictureThumbnail2, 20);
            thumbnailContainer.Children.Add(pictureThumbnail2);
        }

        private void onCanvasClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Point position = e.GetPosition(this);
        }
    }
}
