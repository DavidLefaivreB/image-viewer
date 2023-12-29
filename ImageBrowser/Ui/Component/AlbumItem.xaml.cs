using System.Windows.Controls;
using System.Windows.Media;

namespace ImageBrowser.Ui.Component;

public partial class AlbumItem : UserControl
{
    public string ThumbnailPath => @"D:\patreon\ayyaSAP\pack57\thumbnail\Kim Possible nsfw.jpg";
    
    public AlbumItem()
    {
        InitializeComponent();
        DataContext = this;
        
        Background = Brushes.Transparent;
    }
}