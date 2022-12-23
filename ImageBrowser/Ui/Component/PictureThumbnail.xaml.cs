using System.Diagnostics;
using System.Windows.Controls;

namespace ImageBrowser.Ui.Component
{
    /// <summary>
    /// Interaction logic for PictureThumbnail.xaml
    /// </summary>
    public partial class PictureThumbnail : UserControl
    {
        public string Path
        {
            get;
            set;
        }

        public string Description
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
                Process.Start(Path);
        }
    }
}
