using System.Windows;
using System.Windows.Controls;
using ImageBrowser.Controller;

namespace ImageBrowser.Ui
{
    public partial class RightPanel
    {
        private ThumbnailsController _thumbnailsController;
        
        public RightPanel()
        {
            InitializeComponent();
        }

        public void SetPictureRepository(ThumbnailsController thumbnailsController)
        {
            _thumbnailsController = thumbnailsController;
        }

        private void OnCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            _thumbnailsController.AddCategory(((CheckBox)sender).Content.ToString());
        }
        
        private void OnCheckBoxUnchecked(object sender, RoutedEventArgs e)
        {
            _thumbnailsController.RemoveCategory(((CheckBox)sender).Content.ToString());
        }
    }
}