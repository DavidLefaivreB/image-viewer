using System.Windows.Input;
using ImageBrowser.Store;

namespace ImageBrowser.ViewModel;

public class GalleryViewModel : ViewModelBase
{
    public ICommand NavigateAccountCommand { get; }

    public GalleryViewModel(NavigationStore navigationStore)
    {
        // NavigateAccountCommand = new NavigateCommand<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
    }
}