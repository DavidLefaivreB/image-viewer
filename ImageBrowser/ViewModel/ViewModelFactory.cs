using System.Collections.Generic;
using ImageBrowser.Navigation;
using ImageBrowser.Notifier;
using ImageBrowser.Thumbnail;
using ImageBrowser.UI;

namespace ImageBrowser.ViewModel;

public class ViewModelFactory
{
    private readonly GalleryFilterViewModel _galleryFilterViewModel;
    private readonly NavigationHandler _navigationHandler;
    private readonly List<string> _categories;
    private readonly ThumbnailToDisplayNotifier _notifier;
    private FileThumbnailController _fileThumbnailController;
    private readonly MainWindow.IShowAddPicturesWindowAction _showWindowAction;

    public ViewModelFactory(GalleryFilterViewModel galleryFilterViewModel,
        NavigationHandler navigationHandler,
        List<string> categories,
        ThumbnailToDisplayNotifier notifier, 
        FileThumbnailController fileThumbnailController,
        MainWindow.IShowAddPicturesWindowAction showWindowAction)
    {
        _galleryFilterViewModel = galleryFilterViewModel;
        _navigationHandler = navigationHandler;
        _categories = categories;
        _notifier = notifier;
        _fileThumbnailController = fileThumbnailController;
        _showWindowAction = showWindowAction;
    }

    public GalleryViewModel CreateGalleryViewModel()
    {
        var galleryViewModel = new GalleryViewModel(_galleryFilterViewModel, _navigationHandler, _fileThumbnailController, _showWindowAction);
        _notifier.AddListener(galleryViewModel);
        
        return galleryViewModel;
    }

    public EditAlbumViewModel CreateEditAlbumViewModel()
    {
        _notifier.ClearListeners();
        return new EditAlbumViewModel(_navigationHandler, _categories, _fileThumbnailController);
    }
}