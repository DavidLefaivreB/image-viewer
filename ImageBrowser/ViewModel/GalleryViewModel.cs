using System.Collections.Generic;
using System.Windows.Forms;
using ImageBrowser.Model;
using ImageBrowser.Navigation;
using ImageBrowser.Notifier;
using ImageBrowser.Thumbnail;
using ImageBrowser.Utils;

namespace ImageBrowser.ViewModel;

public class GalleryViewModel : ViewModelBase, ThumbnailsListener
{
    private readonly NavigationHandler _navigationHandler;

    private List<Picture> _filteredPictures = new();
    private readonly FileThumbnailController _fileThumbnailController;

    public GalleryViewModel(GalleryFilterViewModel galleryFilterViewModel, NavigationHandler navigationHandler, FileThumbnailController fileThumbnailController)
    {
        GalleryFilterViewDataContext = galleryFilterViewModel;
        _navigationHandler = navigationHandler;
        _fileThumbnailController = fileThumbnailController;
    }

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

    public void CreateNewAlbum()
    {
        using var dialog = new FolderBrowserDialog();
        
        if (dialog.ShowDialog() == DialogResult.OK)
            _navigationHandler.ShowEditAlbumView(dialog.SelectedPath);
    }

    public void AddFilesToGallery(List<string> files)
    {
        List<string> pictureFiles = FileExtensionUtils.RetrieveValidExtensionFiles(files);

        if (pictureFiles.Count > 0)
        {
            _fileThumbnailController.CreateThumbnailsFor(pictureFiles);
        }
    }
}