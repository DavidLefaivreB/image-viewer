﻿using System.Collections.Generic;
using System.Windows.Input;
using ImageBrowser.Model;
using ImageBrowser.Notifier;
using ImageBrowser.Store;

namespace ImageBrowser.ViewModel;

public class GalleryViewModel : ViewModelBase, ThumbnailsListener
{
    private List<Picture> _filteredPictures = new();
    
    public GalleryViewModel(NavigationStore navigationStore, GalleryFilterViewModel galleryFilterViewModel)
    {
        // NavigateAccountCommand = new NavigateCommand<AccountViewModel>(navigationStore, () => new AccountViewModel(navigationStore));
        
        GalleryFilterViewDataContext = galleryFilterViewModel;
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

    public void CreateNewAlbum()
    {
        
    }
}