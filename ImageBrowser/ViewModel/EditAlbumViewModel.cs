using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using ImageBrowser.Commands;
using ImageBrowser.Navigation;
using ImageBrowser.Thumbnail;
using ImageBrowser.Ui.Component;

namespace ImageBrowser.ViewModel;

public class EditAlbumViewModel : ViewModelBase
{
    static readonly List<string> SupportedExtension = new() { ".jpg", ".jpeg", ".png" };

    private readonly List<string> _categories;
    private List<AlbumThumbnail> _albumThumbnails;
    private FileThumbnailController _fileThumbnailController;

    public EditAlbumViewModel(NavigationHandler navigationHandler, List<string> categories, FileThumbnailController fileThumbnailController)
    {
        _categories = categories;
        _fileThumbnailController = fileThumbnailController;
        SaveAlbumCommand = new CreateAlbumCommand(navigationHandler);

        AlbumThumbnails = new List<AlbumThumbnail>();
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

    public void UpdateAlbumFolder(string albumFolder)
    {
        var files = Directory.EnumerateFiles(albumFolder).Where(file => SupportedExtension.Contains(Path.GetExtension(file).ToLowerInvariant())).ToList();
        _fileThumbnailController.CreateThumbnailsFor(files);
        
        AlbumThumbnails = files.Select(file => new AlbumThumbnail(_fileThumbnailController.GetFor(file), _categories)).ToList();
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