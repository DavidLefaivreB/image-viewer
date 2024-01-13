using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using ImageBrowser.Commands;
using ImageBrowser.Model;
using ImageBrowser.Navigation;
using ImageBrowser.Ui.Component;

namespace ImageBrowser.ViewModel;

public class EditAlbumViewModel : ViewModelBase
{
    private List<AlbumThumbnail> _albumThumbnails;
    
    public EditAlbumViewModel(NavigationHandler navigationHandler, IEnumerable<Picture> pictures, List<string> categories)
    {
        SaveAlbumCommand = new CreateAlbumCommand(navigationHandler);

        var albumThumbnails = pictures.Select(p => new AlbumThumbnail(p, categories)).ToList();
        AlbumThumbnails = albumThumbnails;
    }
    
    public ICommand SaveAlbumCommand { get; }

    public List<AlbumThumbnail> AlbumThumbnails
    {
        get => _albumThumbnails;
        set
        {
            _albumThumbnails = value;
            OnPropertyChanged();
        }
    }

    private class CreateAlbumCommand : CommandBases
    {
        private readonly NavigationHandler _navigationHandler;

        public CreateAlbumCommand(NavigationHandler navigationHandler)
        {
            _navigationHandler = navigationHandler;
        }
        
        public override void Execute(object parameter)
        {
            _navigationHandler.ShowGalleryView();
        }
    }
}