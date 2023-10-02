using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ImageBrowser.Ui.Component;

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

            AddThumbnail(@"D:\patreon\yupachu\april_2018\thumbnail\2b.jpg", "2b");
            AddThumbnail(@"D:\patreon\yupachu\april_2018\thumbnail\Faith.jpg", "Faith");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\ada_sfw1.jpg", "Ada");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\catwoman_sfw.jpg", "Catwoman");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\ahsoka_tano_sfw1.jpg", "Ahsoka");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\bowsette_sfw1.jpg", "Bowsette");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\bloodrayne_sfw1.jpg", "Bloodrayne");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\april.jpg", "April");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\felicia_nude4.jpg", "Felicia");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\gwen_sfw.jpg", "Gwen");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\laura_kinney_sfw2.jpg", "Laura Kinney");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\hermione_sfw.jpg", "Hermione");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\velma_sfw1.jpg", "Velma");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\unnamed_sfw.jpg", "Unnamed");
            AddThumbnail(@"D:\patreon\aliceRauch\thumbnail\zelda_sfw.jpg", "Zelda");
        }

        List<PictureThumbnail> thumbnails = new List<PictureThumbnail>();

        void AddThumbnail(string path, string name)
        {
            PictureThumbnail pictureThumbnail = new PictureThumbnail();
            pictureThumbnail.Path = path;
            pictureThumbnail.Description = name;

            thumbnails.Add(pictureThumbnail);
        }

        private void onCanvasClick(object sender, MouseButtonEventArgs e)
        {
            Point position = e.GetPosition(this);
        }

        private void onControlSizeChanged(object sender, SizeChangedEventArgs e)
        {
            thumbnailContainer.Children.Clear();
            var nbThumbnailsByRow = (int)e.NewSize.Width / 200;
            
            for (var i = 0; i < thumbnails.Count; i++)
            {
                var rowIndex = i / nbThumbnailsByRow;
                var columnIndex = i - rowIndex * nbThumbnailsByRow;

                Canvas.SetLeft(thumbnails[i], columnIndex * 200 + 20);
                Canvas.SetTop(thumbnails[i], rowIndex * 200);
                thumbnailContainer.Children.Add(thumbnails[i]);
            }

            thumbnailContainer.Height = thumbnails.Count / nbThumbnailsByRow * 200 + 240;
            scroller.Height = e.NewSize.Height;
        }
    }
}
