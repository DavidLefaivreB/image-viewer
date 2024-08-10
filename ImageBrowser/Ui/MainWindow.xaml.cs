using System.Collections.Generic;
using System.IO;
using System.Windows;
using ImageBrowser.Controller;
using ImageBrowser.Navigation;
using ImageBrowser.Notifier;
using ImageBrowser.Repository.Sql;
using ImageBrowser.Thumbnail;
using ImageBrowser.Ui.View.Gallery;
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

        var yo = Directory.GetFiles("D:\\patreon\\ayyaSAP\\pack57\\thumbnail");
        
        var repositoryFactory = new SqlRepositoryFactory();
        var pictureRepository = repositoryFactory.CreatePictureRepository();
        var franchiseRepository = repositoryFactory.CreateFranchiseRepository();
        var categoryRepository = repositoryFactory.CreateCategoryRepository();

        var notifier = new ThumbnailToDisplayNotifier();
        var thumbnailsController = new ThumbnailsController(pictureRepository, notifier);

        var navigationHandler = new NavigationHandler(navigationStore);
        
        var galleryFilterViewModel = new GalleryFilterViewModel(thumbnailsController, categoryRepository.RetrieveAll(), franchiseRepository.RetrieveAll());
        var viewModelFactory = new ViewModelFactory(galleryFilterViewModel, navigationHandler, categoryRepository.RetrieveAll(), notifier, new FileThumbnailController(new ThumbnailGenerator()), new Impl(this));
        navigationHandler.ViewModelFactory = viewModelFactory;

        notifier.Notify(pictureRepository.RetrieveAll());

        navigationHandler.ShowGalleryView();
        
        InitializeComponent();
    }
    
    public interface IShowAddPicturesWindowAction
    {
        public void Show(List<string> pictures);
    }

    private class Impl : IShowAddPicturesWindowAction
    {
        private Window _owner;
        
        public Impl(Window owner)
        {
            _owner = owner;
        }
        
        public void Show(List<string> pictures)
        {
            var yo = new AddPicturesWindow();
            yo.Owner = GetWindow(_owner);
            yo.Activate();
            yo.Show();
        }
    }
}