using System.Windows;
using System.Windows.Controls;
using ImageBrowser.Controller;
using ImageBrowser.Notifier;
using ImageBrowser.Repository;
using ImageBrowser.Repository.Sql;
using ImageBrowser.Ui.AddWindow;

namespace ImageBrowser.Ui.View.Gallery;

public partial class GalleryView : UserControl
{
    private PictureRepository _pictureRepository = new SqlPictureRepository();
    private ThumbnailToDisplayNotifier _thumbnailToDisplayNotifier = new();
    private FranchiseRepository _franchiseRepository = new SqlFranchiseRepository();

    public GalleryView()
    {
        InitializeComponent();
        DataContext = this;
            
        _thumbnailToDisplayNotifier.AddListener(thumbnailPanel);
        _thumbnailToDisplayNotifier.Notify(_pictureRepository.RetrieveAll());

        ThumbnailsController thumbnailsController = new ThumbnailsController(_pictureRepository, _thumbnailToDisplayNotifier);
        RightPanel.SetPictureRepository(thumbnailsController);
        RightPanel.UpdateAvailableFranchises(_franchiseRepository.RetrieveAll());
    }
        
    private void AddPicture(object sender, RoutedEventArgs e)
    {
        new AddPictureDialog().ShowDialog();
    }
}