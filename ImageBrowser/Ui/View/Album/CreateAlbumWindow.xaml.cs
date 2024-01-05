using System;
using System.Windows;
using System.Windows.Input;

namespace ImageBrowser.Ui.View.Album;

public partial class CreateAlbumWindow : Window
{
    public CreateAlbumWindow()
    {
        InitializeComponent();

        KeyDown += OnWindowKeyDownPressed;
    }

    private void OnWindowKeyDownPressed(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Escape)
            Close();
    }

    private void OnCancelButtonClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}