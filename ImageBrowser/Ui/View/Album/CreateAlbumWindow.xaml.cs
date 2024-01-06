using System;
using System.Windows;
using System.Windows.Controls;

namespace ImageBrowser.Ui.View.Album;

public partial class CreateAlbumWindow : Window
{
    public CreateAlbumWindow()
    {
        InitializeComponent();
    }

    private void OnCreateButtonClick(object sender, RoutedEventArgs e)
    {
        Close();
    }

    private void OnTextChanged(object sender, TextChangedEventArgs e)
    {
        CreateButton.IsEnabled = !string.IsNullOrWhiteSpace(NameTextBox.Text) && !string.IsNullOrWhiteSpace(AuthorTextBox.Text) && !string.IsNullOrWhiteSpace(PathTextBox.Text);
    }
}