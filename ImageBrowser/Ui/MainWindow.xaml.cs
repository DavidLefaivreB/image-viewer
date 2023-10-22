using System;
using System.Collections.Generic;
using System.Windows;
using ImageBrowser.Controller;
using ImageBrowser.Notifier;
using ImageBrowser.Repository;
using ImageBrowser.Repository.Sql;
using Microsoft.Data.Sqlite;

namespace ImageBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PictureRepository _pictureRepository = new PictureRepositoryInMemory();
        private ThumbnailToDisplayNotifier _thumbnailToDisplayNotifier = new ThumbnailToDisplayNotifier();
        private FranchiseRepository _franchiseRepository = new SqlFranchiseRepository();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            
            _thumbnailToDisplayNotifier.AddListener(thumbnailPanel);
            _thumbnailToDisplayNotifier.Notify(_pictureRepository.RetrieveAll());

            ThumbnailsController thumbnailsController = new ThumbnailsController(_pictureRepository, _thumbnailToDisplayNotifier);
            rightPanel.SetPictureRepository(thumbnailsController);
            rightPanel.UpdateAvailableFranchises(_franchiseRepository.RetrieveAll());
            rightPanel.UpdateAvailableCategories(new List<string>(){"Normal", "Lingerie", "Bottomless", "Topless", "Nude", "Pubes", "Tanline", "Cum", "Futacum", "Futa", "Alternate"});
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
