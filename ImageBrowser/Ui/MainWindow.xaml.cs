using ImageBrowser.Controller;
using ImageBrowser.Navigation;
using ImageBrowser.Notifier;
using ImageBrowser.Repository.Sql;
using ImageBrowser.ViewModel;

namespace ImageBrowser.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow
{
    public MainWindow()
    {
        var navigationStore = new NavigationStore();
        DataContext = new MainViewModel(navigationStore);

        var repositoryFactory = new SqlRepositoryFactory();
        var pictureRepository = repositoryFactory.CreatePictureRepository();
        var franchiseRepository = repositoryFactory.CreateFranchiseRepository();
        var categoryRepository = repositoryFactory.CreateCategoryRepository();

        var notifier = new ThumbnailToDisplayNotifier();
        var thumbnailsController = new ThumbnailsController(pictureRepository, notifier);

        var navigationHandler = new NavigationHandler(navigationStore);
        
        var galleryFilterViewModel = new GalleryFilterViewModel(thumbnailsController, categoryRepository.RetrieveAll(), franchiseRepository.RetrieveAll());
        var viewModelFactory = new ViewModelFactory(galleryFilterViewModel, navigationHandler, pictureRepository.RetrieveAll(), categoryRepository.RetrieveAll());
        navigationHandler.ViewModelFactory = viewModelFactory;
        
        notifier.Notify(pictureRepository.RetrieveAll());

        navigationHandler.ShowGalleryView();
        
        InitializeComponent();
    }
}