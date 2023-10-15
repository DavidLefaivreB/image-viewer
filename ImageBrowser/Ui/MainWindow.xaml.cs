using System.Windows;
using ImageBrowser.Controller;
using ImageBrowser.Notifier;
using ImageBrowser.Repository;

namespace ImageBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PictureRepository _pictureRepository = new PictureRepositoryInMemory();
        private ThumbnailToDisplayNotifier _thumbnailToDisplayNotifier = new ThumbnailToDisplayNotifier();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            
            _thumbnailToDisplayNotifier.AddListener(thumbnailPanel);
            _thumbnailToDisplayNotifier.Notify(_pictureRepository.RetrieveAll());

            ThumbnailsController thumbnailsController = new ThumbnailsController();
            rightPanel.SetPictureRepository(thumbnailsController);
        }
        
        private void OnMinimizeButtonClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void OnMaximizeRestoreButtonClick(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Maximized)
                WindowState = WindowState.Normal;
            else
                WindowState = WindowState.Maximized;
        }

        private void OnCloseButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
