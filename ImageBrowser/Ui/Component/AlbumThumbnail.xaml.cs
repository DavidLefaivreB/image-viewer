using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Media;

namespace ImageBrowser.Ui.Component;

public partial class AlbumThumbnail : UserControl
{
    public string ThumbnailPath { get; set; }
    
    public AlbumThumbnail(string picture, List<string> categories)
    {
        InitializeComponent();
        DataContext = this;
        
        Background = Brushes.Transparent;

        ThumbnailPath = picture;
        CategoryPanel.Items = categories;
    }
}