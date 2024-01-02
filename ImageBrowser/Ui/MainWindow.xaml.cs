using System.Windows;
using ImageBrowser.Controller;
using ImageBrowser.Notifier;
using ImageBrowser.Repository;
using ImageBrowser.Repository.Sql;
using ImageBrowser.Store;
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

            var notifier = new ThumbnailToDisplayNotifier();
            var pictureRepository = new SqlPictureRepository();
            var thumbnailsController = new ThumbnailsController(pictureRepository, notifier);
            var galleryViewModel = new GalleryViewModel(navigationStore, new GalleryFilterViewModel(thumbnailsController, new SqlFranchiseRepository().RetrieveAll()));
            
            notifier.AddListener(galleryViewModel);
            notifier.Notify(pictureRepository.RetrieveAll());
            
            RepositoryProvider.Instance.SetRepositoryFactory(new SqlRepositoryFactory());
            navigationStore.CurrentViewModel = galleryViewModel;
            
            InitializeComponent();
        }
    }
}
