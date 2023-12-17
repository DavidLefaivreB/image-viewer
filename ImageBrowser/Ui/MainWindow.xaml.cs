using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls.Primitives;
using ImageBrowser.Controller;
using ImageBrowser.Notifier;
using ImageBrowser.Repository;
using ImageBrowser.Repository.Sql;
using ImageBrowser.Ui.AddWindow;
using Microsoft.Data.Sqlite;

namespace ImageBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private PictureRepository _pictureRepository = new SqlPictureRepository();
        private ThumbnailToDisplayNotifier _thumbnailToDisplayNotifier = new();
        private FranchiseRepository _franchiseRepository = new SqlFranchiseRepository();
        private CategoryRepository _categoryRepository = new SqlCategoryRepository();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            
            _thumbnailToDisplayNotifier.AddListener(thumbnailPanel);
            _thumbnailToDisplayNotifier.Notify(_pictureRepository.RetrieveAll());

            ThumbnailsController thumbnailsController = new ThumbnailsController(_pictureRepository, _thumbnailToDisplayNotifier);
            rightPanel.SetPictureRepository(thumbnailsController);
            rightPanel.UpdateAvailableFranchises(_franchiseRepository.RetrieveAll());
            rightPanel.UpdateAvailableCategories(_categoryRepository.RetrieveAll());
        }
        
        private void AddPicture(object sender, RoutedEventArgs e)
        {
            new AddPictureDialog().ShowDialog();
        }
    }
}
