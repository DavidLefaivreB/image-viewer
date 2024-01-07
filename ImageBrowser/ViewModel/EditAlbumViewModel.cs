using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using ImageBrowser.Commands;
using ImageBrowser.Model;
using ImageBrowser.Ui.Component;

namespace ImageBrowser.ViewModel;

public class EditAlbumViewModel : ViewModelBase
{
    private List<AlbumThumbnail> _albumThumbnails;
    
    public EditAlbumViewModel(IEnumerable<Picture> pictures, List<string> categories)
    {
        // NavigateGalleryViewCommand = new BasicCommand(navigationNotifier.ShowEditAlbumView);

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
}