using ImageBrowser.ViewModel;

namespace ImageBrowser.Navigation;

public class NavigationHandler
{
    private readonly NavigationStore _navigationStore;

    private EditAlbumViewModel _editAlbumViewModel;

    public NavigationHandler(NavigationStore navigationStore)
    {
        _navigationStore = navigationStore;
    }
    
    public void ShowEditAlbumView()
    {
        _navigationStore.CurrentViewModel = _editAlbumViewModel;
    }

    public void SetEditAlbumViewModel(EditAlbumViewModel editAlbumViewModel)
    {
        _editAlbumViewModel = editAlbumViewModel;
    }
}