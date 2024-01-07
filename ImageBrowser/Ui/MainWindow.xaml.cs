using System.Windows;
using ImageBrowser.Controller;
using ImageBrowser.Navigation;
using ImageBrowser.Notifier;
using ImageBrowser.Repository.Sql;
using ImageBrowser.Ui.View.Album;
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
        var editAlbumViewModel = new EditAlbumViewModel(pictureRepository.RetrieveAll(), categoryRepository.RetrieveAll());
        var galleryViewModel = new GalleryViewModel(galleryFilterViewModel, () => CreateAlbum(navigationHandler));

        navigationHandler.SetEditAlbumViewModel(editAlbumViewModel);
        
        notifier.AddListener(galleryViewModel);
        notifier.Notify(pictureRepository.RetrieveAll());

        navigationStore.CurrentViewModel = galleryViewModel;

        InitializeComponent();
    }

    //Todo move logic into a class
    private void CreateAlbum(NavigationHandler navigationNotifier)
    {
        var window = new CreateAlbumWindow
        {
            Owner = this,
            WindowStartupLocation = WindowStartupLocation.CenterOwner
        };

        if (window.ShowDialog() == true)
            navigationNotifier.ShowEditAlbumView();
    }
}