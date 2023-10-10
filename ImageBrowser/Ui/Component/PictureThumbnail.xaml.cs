using System.Diagnostics;
using System.Windows.Controls;
using ImageBrowser.Model;

namespace ImageBrowser.Ui.Component
{
    /// <summary>
    /// Interaction logic for PictureThumbnail.xaml
    /// </summary>
    public partial class PictureThumbnail : UserControl
    {
        public Picture Picture
        {
            get;
            set;
        }
        
        public PictureThumbnail()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void onThumbnailClicked(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (e.ClickCount > 1)
                Process.Start(Picture.ImagePath);
        }
    }
}
