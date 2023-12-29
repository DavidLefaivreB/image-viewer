﻿using System.Windows;
using ImageBrowser.Store;
using ImageBrowser.ViewModel;

namespace ImageBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var navigationStore = new NavigationStore();
            navigationStore.CurrentViewModel = new EditAlbumViewModel(navigationStore);
            
            DataContext = new MainViewModel(navigationStore);
        }
    }
}
