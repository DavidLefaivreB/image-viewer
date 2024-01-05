using System.Runtime.CompilerServices;
using System.Windows;
using ImageBrowser.Controller;
using ImageBrowser.Notifier;
using ImageBrowser.Repository.Sql;
using ImageBrowser.Store;
using ImageBrowser.Ui.View.Album;
using ImageBrowser.ViewModel;

namespace ImageBrowser.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
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
            var galleryViewModel = new GalleryViewModel(navigationStore, new GalleryFilterViewModel(thumbnailsController, categoryRepository.RetrieveAll(), franchiseRepository.RetrieveAll()));
            
            notifier.AddListener(galleryViewModel);
            notifier.Notify(pictureRepository.RetrieveAll());
            
            navigationStore.CurrentViewModel = galleryViewModel;
            
            InitializeComponent();
        }

        //Todo move logic into a class
        private void CreateAlbum()
        {
            var window = new CreateAlbumWindow();
            window.Owner = this;
            window.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            window.ShowDialog();
        }
    }
}
