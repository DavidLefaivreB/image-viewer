using ImageBrowser.Controller;
using ImageBrowser.Repository;

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
    }
}