using System;
using System.Collections.Generic;
using ImageBrowser.Model;
using ImageBrowser.Notifier;

namespace ImageBrowser.ViewModel;

public class GalleryViewModel : ViewModelBase, ThumbnailsListener
{
    private readonly Action _createAlbum;
    private List<Picture> _filteredPictures = new();
    
    public GalleryViewModel(GalleryFilterViewModel galleryFilterViewModel, Action createAlbum)
    {
        _createAlbum = createAlbum;
        
        GalleryFilterViewDataContext = galleryFilterViewModel;
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
        _createAlbum.Invoke();
    }
}