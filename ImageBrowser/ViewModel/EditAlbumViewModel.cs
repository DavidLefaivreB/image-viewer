using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Input;
using ImageBrowser.Commands;
using ImageBrowser.Model;
using ImageBrowser.Navigation;
using ImageBrowser.Ui.Component;

namespace ImageBrowser.ViewModel;

public class EditAlbumViewModel : ViewModelBase
{
    static readonly List<string> SupportedExtension = new() { ".jpg", ".jpeg", ".png" };

    private readonly List<string> _categories;
    private List<AlbumThumbnail> _albumThumbnails;

    public EditAlbumViewModel(NavigationHandler navigationHandler, List<string> categories)
    {
        _categories = categories;
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
        var files = Directory.EnumerateFiles(albumFolder).Where(file => SupportedExtension.Contains(Path.GetExtension(file).ToLowerInvariant()));
        AlbumThumbnails = files.Select(file => new AlbumThumbnail(file, _categories)).ToList();
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