using System.Windows.Controls;
using System.Windows.Media;
using ImageBrowser.Model;

namespace ImageBrowser.Ui.Component;

public partial class AlbumItem : UserControl
{
    public string ThumbnailPath { get; set; }
    
    public AlbumItem(Picture picture)
    {
        InitializeComponent();
        DataContext = this;
        
        Background = Brushes.Transparent;

        ThumbnailPath = picture.ThumbnailPath;
    }
}