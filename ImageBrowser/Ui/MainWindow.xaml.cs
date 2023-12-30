using System.Windows;
using ImageBrowser.Repository;
using ImageBrowser.Repository.InMemory;
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

            RepositoryProvider.Instance.SetRepositoryFactory(new InMemoryRepositoryFactory());
            navigationStore.CurrentViewModel = new EditAlbumViewModel(navigationStore, RepositoryProvider.Instance.getPictureRepository().RetrieveAll());
            
            InitializeComponent();
        }
    }
}
