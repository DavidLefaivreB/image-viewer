using System.Collections.Generic;
using System.Windows.Input;
using ImageBrowser.Controller;
using ImageBrowser.Model;
using ImageBrowser.Notifier;
using ImageBrowser.Repository;
using ImageBrowser.Store;

namespace ImageBrowser.ViewModel;

public class GalleryViewModel : ViewModelBase, ThumbnailsListener
{
    private List<Picture> _filteredPictures = new();
    
    public GalleryViewModel(NavigationStore navigationStore, ThumbnailToDisplayNotifier notifier, PictureRepository pictureRepository, FranchiseRepository franchiseRepository)
    {
        // NavigateAccountCommand = new NavigateCommand<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
     
        notifier.AddListener(this);
        notifier.Notify(pictureRepository.RetrieveAll());
        
        GalleryFilterViewDataContext = new GalleryFilterViewModel(new ThumbnailsController(pictureRepository, notifier), franchiseRepository.RetrieveAll());
    }
    
    public ICommand NavigateAccountCommand { get; }
    
    public object GalleryFilterViewDataContext { get; }

    public List<Picture> FilteredPictures
    {
        get => _filteredPictures;
        set
        {
            _filteredPictures = value;
            OnPropertyChanged();
        }
    }
    public void Notify(List<Picture> pictures)
    {
        FilteredPictures = pictures;
    }
}