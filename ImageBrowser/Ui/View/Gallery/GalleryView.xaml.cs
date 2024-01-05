using System.Windows;
using ImageBrowser.ViewModel;

namespace ImageBrowser.Ui.View.Gallery;

public partial class GalleryView
{
    public GalleryView()
    {
        InitializeComponent();
    }

    private GalleryViewModel ViewModel { get; set; }
    
    private void OnAddButtonClick(object sender, RoutedEventArgs e)
    {
        ViewModel.CreateNewAlbum();
    }
    
    private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
        ViewModel = DataContext as GalleryViewModel;
    }
}