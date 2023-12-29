using System.Windows.Input;
using ImageBrowser.Commands;
using ImageBrowser.Store;

namespace ImageBrowser.ViewModel;

public class EditAlbumViewModel : ViewModelBase
{
    public ICommand NavigateAccountCommand { get; }
    
    public EditAlbumViewModel(NavigationStore navigationStore)
    {
        NavigateAccountCommand = new NavigateCommand<GalleryViewModel>(navigationStore, () => new GalleryViewModel(navigationStore));
    }
}