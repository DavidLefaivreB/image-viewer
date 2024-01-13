using System.Collections.Generic;
using System.Windows.Forms;
using ImageBrowser.Model;
using ImageBrowser.ViewModel;

namespace ImageBrowser.Navigation;

public class NavigationHandler
{
    private readonly NavigationStore _navigationStore;
    private readonly List<Picture> _pictures;
    private readonly List<string> _categories;
    private readonly GalleryFilterViewModel _galleryFilterViewModel;

    public NavigationHandler(NavigationStore navigationStore, List<Picture> pictures, List<string> categories, GalleryFilterViewModel galleryFilterViewModel)
    {
        _navigationStore = navigationStore;
        _pictures = pictures;
        _categories = categories;
        _galleryFilterViewModel = galleryFilterViewModel;
    }
    
    public void ShowEditAlbumView(DialogResult albumFolder)
    {
        _navigationStore.CurrentViewModel = new EditAlbumViewModel(this, _pictures, _categories);
    }

    public void ShowGalleryView()
    {
        _navigationStore.CurrentViewModel = new GalleryViewModel(_galleryFilterViewModel, this);
    }
}