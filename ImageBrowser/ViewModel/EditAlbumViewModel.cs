using System.Collections.Generic;
using System.Windows.Input;
using ImageBrowser.Commands;
using ImageBrowser.Repository;
using ImageBrowser.Store;

namespace ImageBrowser.ViewModel;

public class EditAlbumViewModel : ViewModelBase
{
    public ICommand NavigateAccountCommand { get; }

    private List<string> _categoryList;

    public List<string> CategoryList
    {
        get => _categoryList;
        set
        {
            _categoryList = value;
            OnPropertyChanged();
        }
    }

    public string ThumbnailPath => @"D:\patreon\ayyaSAP\pack57\thumbnail\Bastila Shan alt.jpg";

    public EditAlbumViewModel(NavigationStore navigationStore, CategoryRepository categoryRepository)
    {
        NavigateAccountCommand = new NavigateCommand<GalleryViewModel>(navigationStore, () => new GalleryViewModel(navigationStore));
        CategoryList = categoryRepository.RetrieveAll();
    }
}