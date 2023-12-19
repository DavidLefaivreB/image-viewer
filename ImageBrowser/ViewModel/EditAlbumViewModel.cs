using System.Windows.Input;
using ImageBrowser.Store;

namespace ImageBrowser.ViewModel;

public class EditAlbumViewModel : ViewModelBase
{
    public ICommand NavigateAccountCommand { get; }

    public EditAlbumViewModel(NavigationStore navigationStore)
    {
        // NavigateAccountCommand = new NavigateCommand<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
    }
}