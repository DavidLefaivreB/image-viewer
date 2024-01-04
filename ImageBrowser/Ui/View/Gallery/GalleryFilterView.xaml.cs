using System.Windows;
using System.Windows.Controls;
using ImageBrowser.ViewModel;

namespace ImageBrowser.Ui.View.Gallery
{
    public partial class GalleryFilterView
    {
        private GalleryFilterViewModel _viewModel;

        public GalleryFilterView()
        {
            InitializeComponent();
        }
        
        private void OnCheckBoxChecked(object sender)
        {
            _viewModel?.AddCategory(((CheckBox)sender).Content.ToString());
        }

        private void OnCheckBoxUnchecked(object sender)
        {
            _viewModel?.RemoveCategory(((CheckBox)sender).Content.ToString());
        }

        private void OnFranchiseAdded(object franchise)
        {
            _viewModel?.AddFranchise((string)franchise);
        }

        private void OnTagRemoved(object franchise)
        {
            _viewModel?.RemoveFranchise((string)franchise);
        }

        private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            _viewModel = DataContext as GalleryFilterViewModel;
        }
        
        private void OnAddButtonClick(object sender, RoutedEventArgs e)
        {
        
        }
    }
}