using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;
using ImageBrowser.Model;

namespace ImageBrowser.Ui.Component;

public partial class AlbumThumbnail : UserControl
{
    public string ThumbnailPath { get; set; }
    
    public AlbumThumbnail(Picture picture, List<string> categories)
    {
        InitializeComponent();
        DataContext = this;
        
        Background = Brushes.Transparent;

        ThumbnailPath = picture.ThumbnailPath;
        CategoryPanel.Items = categories;
    }
}