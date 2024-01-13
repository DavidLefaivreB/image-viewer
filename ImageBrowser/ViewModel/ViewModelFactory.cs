using System.Collections.Generic;
using ImageBrowser.Model;
using ImageBrowser.Navigation;

namespace ImageBrowser.ViewModel;

public class ViewModelFactory
{
    private readonly GalleryFilterViewModel _galleryFilterViewModel;
    private readonly NavigationHandler _navigationHandler;
    private readonly List<Picture> _pictures;
    private readonly List<string> _categories;

    public ViewModelFactory(GalleryFilterViewModel galleryFilterViewModel, NavigationHandler navigationHandler, List<Picture> pictures, List<string> categories)
    {
        _galleryFilterViewModel = galleryFilterViewModel;
        _navigationHandler = navigationHandler;
        _pictures = pictures;
        _categories = categories;
    }

    public GalleryViewModel CreateGalleryViewModel()
    {
        return new GalleryViewModel(_galleryFilterViewModel, _navigationHandler);
    }

    public EditAlbumViewModel CreateEditAlbumViewModel()
    {
        return new EditAlbumViewModel(_navigationHandler, _pictures, _categories);
    }
}