using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using ImageBrowser.Controller;
using ImageBrowser.Model;

namespace ImageBrowser.Ui.View.Gallery
{
    public partial class GalleryFilterView : INotifyPropertyChanged
    {
        private ThumbnailsController _thumbnailsController;
        private List<Picture> _pictures;

        public GalleryFilterView()
        {
            InitializeComponent();
            DataContext = this;
            
            Franchises = new List<string> { "Star Wars" };
        }

        public List<string> Franchises { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void SetPictureRepository(ThumbnailsController thumbnailsController)
        {
            _thumbnailsController = thumbnailsController;
        }

        private void OnCheckBoxChecked(object sender)
        {
            _thumbnailsController.AddCategory(((CheckBox)sender).Content.ToString());
        }

        private void OnCheckBoxUnchecked(object sender)
        {
            _thumbnailsController.RemoveCategory(((CheckBox)sender).Content.ToString());
        }

        private void OnFranchiseAdded(object franchise)
        {
            _thumbnailsController.AddFranchise((string)franchise);
        }

        private void OnTagRemoved(object franchise)
        {
            _thumbnailsController.RemoveFranchise((string)franchise);
        }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}