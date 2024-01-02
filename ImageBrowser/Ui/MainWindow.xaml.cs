using System.Windows;
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
            
            RepositoryProvider.Instance.SetRepositoryFactory(new SqlRepositoryFactory());
            navigationStore.CurrentViewModel = new GalleryViewModel(navigationStore, notifier, new SqlPictureRepository(), new SqlFranchiseRepository());
            
            InitializeComponent();
        }
    }
}
