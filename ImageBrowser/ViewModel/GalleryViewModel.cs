using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using ImageBrowser.Model;
using ImageBrowser.Navigation;
using ImageBrowser.Notifier;

namespace ImageBrowser.ViewModel;

public class GalleryViewModel : ViewModelBase, ThumbnailsListener
{
    private readonly NavigationHandler _navigationHandler;

    private List<Picture> _filteredPictures = new();

    public GalleryViewModel(GalleryFilterViewModel galleryFilterViewModel, NavigationHandler navigationHandler)
    {
        GalleryFilterViewDataContext = galleryFilterViewModel;
        _navigationHandler = navigationHandler;
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
}