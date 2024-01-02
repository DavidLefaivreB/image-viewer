using ImageBrowser.Controller;
using ImageBrowser.Notifier;
using ImageBrowser.Repository;
using ImageBrowser.Repository.Sql;
using ImageBrowser.ViewModel;

namespace ImageBrowser.Ui.View.Gallery;

public partial class GalleryView
{
    private PictureRepository _pictureRepository = RepositoryProvider.Instance.getPictureRepository();
    private ThumbnailToDisplayNotifier _thumbnailToDisplayNotifier = new();
    private FranchiseRepository _franchiseRepository = new SqlFranchiseRepository();
    
    public GalleryView()
    {
        InitializeComponent();
        DataContext = this;

        RightPanel.DataContext = new GalleryFilterViewModel(new ThumbnailsController(_pictureRepository, _thumbnailToDisplayNotifier), _franchiseRepository.RetrieveAll());
        
        _thumbnailToDisplayNotifier.AddListener(thumbnailPanel);
        _thumbnailToDisplayNotifier.Notify(_pictureRepository.RetrieveAll());
    }
}