using System;
using System.Windows;

namespace ImageBrowser.Ui.AddWindow;

public partial class AddPictureDialog : Window
{
    public AddPictureDialog()
    {
        InitializeComponent();
    }

    private void btnDialogOk_Click(object sender, RoutedEventArgs e)
    {
        DialogResult = true;
    }

    private void Window_ContentRendered(object sender, EventArgs e)
    {
    }
}