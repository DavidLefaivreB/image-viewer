using System.Collections.Generic;
using System.Linq;
using System.Windows;
using ImageBrowser.ViewModel;

namespace ImageBrowser.Ui.View.Gallery;

public partial class GalleryView
{
    public GalleryView()
    {
        InitializeComponent();
    }

    private GalleryViewModel ViewModel { get; set; }
    
    private void OnAddButtonClick(object sender, RoutedEventArgs e)
    {
        ViewModel.CreateNewAlbum();
    }
    
    private void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
    {
        ViewModel = DataContext as GalleryViewModel;
    }

    private void OnDropPreview(object sender, DragEventArgs e)
    {
        if (null != e.Data && e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            if (e.Data.GetData(DataFormats.FileDrop) is string[] files)
                ViewModel.AddFilesToGallery(files.ToList());
        }
    }

    private void OnPreviewDragOver(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
        {
            e.Effects = DragDropEffects.Copy;
            e.Handled = true;
        }
        else
        {
            e.Effects = DragDropEffects.None;
        }
    }
}