using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using ImageBrowser.Model;
using ImageBrowser.Ui.Component;

namespace ImageBrowser.Ui.View.Album;

public partial class EditAlbumView
{
    public EditAlbumView()
    {
        InitializeComponent();
    }

    public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register(nameof(Items), typeof(List<Picture>), typeof(EditAlbumView), new PropertyMetadata(new List<AlbumThumbnail>(), OnItemChanged));

    public List<AlbumThumbnail> Items
    {
        get => (List<AlbumThumbnail>)GetValue(ItemsProperty);
        set => SetValue(ItemsProperty, value);
    }

    private static void OnItemChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var panel = d as EditAlbumView;
        panel?.AddAlbumItemsToGrid(e.NewValue as List<AlbumThumbnail>);
    }

    private void AddAlbumItemsToGrid(List<AlbumThumbnail> albumItem)
    {
        AddGridRows(albumItem.Count);

        for (var i = 0; i < albumItem.Count - 1; ++i)
        {
            AddAlbumItemToRow(i, albumItem[i]);

            var separator = new Separator();
            AddSeparatorToRow(separator, i);
        }

        AddAlbumItemToRow((albumItem.Count - 1) * 2, albumItem[^1]);
    }

    private void AddSeparatorToRow(Separator separator, int i)
    {
        Grid.SetRow(separator, i * 2 + 1);
        Grid.SetColumn(separator, i * 2 + 1);

        ItemsGrid.Children.Add(separator);
    }

    private void AddAlbumItemToRow(int rowIndex, AlbumThumbnail albumThumbnail)
    {
        Grid.SetRow(albumThumbnail, rowIndex * 2);
        Grid.SetColumn(albumThumbnail, rowIndex * 2);

        ItemsGrid.Children.Add(albumThumbnail);
    }

    private void AddGridRows(int nbItems)
    {
        ItemsGrid.RowDefinitions.Clear();

        var nbRows = nbItems * 2 - 1;
        for (var i = 0; i < nbRows; ++i)
        {
            var rowDefinition = new RowDefinition();
            rowDefinition.Height = GridLength.Auto;
            ItemsGrid.RowDefinitions.Add(rowDefinition);
        }
    }
}