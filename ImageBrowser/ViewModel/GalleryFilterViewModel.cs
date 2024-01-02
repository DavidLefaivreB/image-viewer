using System.Collections.Generic;
using ImageBrowser.Controller;

namespace ImageBrowser.ViewModel;

public class GalleryFilterViewModel : ViewModelBase
{
    private ThumbnailsController _thumbnailsController;

    
    public GalleryFilterViewModel(ThumbnailsController thumbnailsController, List<string> franchises)
    {
        _thumbnailsController = thumbnailsController;
        Franchises = franchises;
    }
    
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
}