using System.Collections.Generic;
using ImageBrowser.Model;
using ImageBrowser.Navigation;
using ImageBrowser.Notifier;

namespace ImageBrowser.ViewModel;

public class ViewModelFactory
{
    private readonly GalleryFilterViewModel _galleryFilterViewModel;
    private readonly NavigationHandler _navigationHandler;
    private readonly List<string> _categories;
    private readonly ThumbnailToDisplayNotifier _notifier;

    public ViewModelFactory(GalleryFilterViewModel galleryFilterViewModel,
        NavigationHandler navigationHandler,
        List<string> categories,
        ThumbnailToDisplayNotifier notifier)
    {
        _galleryFilterViewModel = galleryFilterViewModel;
        _navigationHandler = navigationHandler;
        _categories = categories;
        _notifier = notifier;
    }

    public GalleryViewModel CreateGalleryViewModel()
    {
        var galleryViewModel = new GalleryViewModel(_galleryFilterViewModel, _navigationHandler);
        _notifier.AddListener(galleryViewModel);
        
        return galleryViewModel;
    }

    public EditAlbumViewModel CreateEditAlbumViewModel()
    {
        _notifier.ClearListeners();
        return new EditAlbumViewModel(_navigationHandler, _categories);
    }
}