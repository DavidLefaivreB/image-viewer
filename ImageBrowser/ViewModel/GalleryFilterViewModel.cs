using System;
using System.Collections.Generic;
using ImageBrowser.Controller;

namespace ImageBrowser.ViewModel;

public class GalleryFilterViewModel : ViewModelBase
{
    private ThumbnailsController _thumbnailsController;
    private readonly Action _createAlbumAction;
    
    public GalleryFilterViewModel(ThumbnailsController thumbnailsController, List<string> categories, List<string> franchises, Action createAlbumAction)
    {
        _thumbnailsController = thumbnailsController;
        Categories = categories;
        Franchises = franchises;
        _createAlbumAction = createAlbumAction;
    }
    
    public List<string> Categories { get; set; }
    
    public List<string> Franchises { get; set; }
    
    public void AddCategory(string category)
    {
        _thumbnailsController.AddCategory(category);
    }

    public void RemoveCategory(string category)
    {
        _thumbnailsController.RemoveCategory(category);
    }

    public void AddFranchise(string franchise)
    {
        _thumbnailsController.AddFranchise(franchise);
    }

    public void RemoveFranchise(string franchise)
    {
        _thumbnailsController.RemoveFranchise(franchise);
    }

    // Todo should not be here, the view for filtering picture to display should not contains logic to add new album
    public void AddNewAlbum()
    {
        _createAlbumAction();
    }
}