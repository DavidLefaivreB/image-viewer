using ImageBrowser.Navigation;

namespace ImageBrowser.ViewModel;

public class MainViewModel : ViewModelBase
{
    private readonly NavigationStore navigationStore;
    
    public ViewModelBase CurrentViewModel => navigationStore.CurrentViewModel;

    public MainViewModel(NavigationStore navigationStore)
    {
        this.navigationStore = navigationStore;

        navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
    }

    private void OnCurrentViewModelChanged()
    {
        OnPropertyChanged(nameof(CurrentViewModel));
    }
}