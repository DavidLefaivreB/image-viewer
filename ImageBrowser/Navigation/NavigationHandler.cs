using System.Windows.Forms;
using ImageBrowser.ViewModel;

namespace ImageBrowser.Navigation;

public class NavigationHandler
{
    private readonly NavigationStore _navigationStore;

    public ViewModelFactory ViewModelFactory { get; set; }

    public NavigationHandler(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }

    public void ShowEditAlbumView(string albumFolder)
    {
        var viewModel = ViewModelFactory.CreateEditAlbumViewModel();
        viewModel.UpdateAlbumFolder(albumFolder);
        _navigationStore.CurrentViewModel = viewModel;
    }

    public void ShowGalleryView()
    {
        _navigationStore.CurrentViewModel = ViewModelFactory.CreateGalleryViewModel();
    }
}