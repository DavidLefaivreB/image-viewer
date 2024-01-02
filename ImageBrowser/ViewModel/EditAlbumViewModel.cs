using System.Collections.Generic;
using System.Windows.Input;
using ImageBrowser.Commands;
using ImageBrowser.Model;
using ImageBrowser.Store;

namespace ImageBrowser.ViewModel;

public class EditAlbumViewModel : ViewModelBase
{
    private List<Picture> _pictures;
    
    public EditAlbumViewModel(NavigationStore navigationStore, GalleryViewModel galleryViewModel, List<Picture> pictures)
    {
        NavigateAccountCommand = new NavigateCommand<GalleryViewModel>(navigationStore, () => galleryViewModel);
        Pictures = pictures;
    }
    
    public ICommand NavigateAccountCommand { get; }

    public List<Picture> Pictures
    {
        get => _pictures;
        set
        {
            _pictures = value;
            OnPropertyChanged();
        }
    }
}