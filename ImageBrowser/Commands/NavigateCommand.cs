using System;
using ImageBrowser.Store;
using ImageBrowser.ViewModel;

namespace ImageBrowser.Commands;

public class NavigateCommand<TViewModel> : CommandBases where TViewModel : ViewModelBase
{
    private readonly NavigationStore _navigationStore;
    private readonly Func<TViewModel> _createViewModel;

    public NavigateCommand(NavigationStore navigationStore, Func<TViewModel> createViewModel)
    {
        _navigationStore = navigationStore;
        _createViewModel = createViewModel;
    }
    
    public override void Execute(object parameter)
    {
        _navigationStore.CurrentViewModel = _createViewModel();
    }
}