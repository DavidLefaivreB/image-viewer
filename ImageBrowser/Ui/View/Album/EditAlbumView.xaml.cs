using System;
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

    public static DependencyProperty SourceProperty =
        DependencyProperty.Register("Source", typeof(List<Picture>), typeof(EditAlbumView), new PropertyMetadata(new List<Picture>(), OnSourceChanged));

    public List<Picture> Source
    {
        get { return (List<Picture>)base.GetValue(SourceProperty); }
        set { base.SetValue(SourceProperty, value); }
    }

    private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var panel = d as EditAlbumView;
        panel?.AddPicturesToGrid(e.NewValue as List<Picture>);
    }

    private void AddPicturesToGrid(List<Picture> pictures)
    {
        AddGridRows(pictures.Count);

        for (var i = 0; i < pictures.Count - 1; ++i)
        {
            AddAlbumItemToRow(i);

            var separator = new Separator();
            AddSepartorToRow(separator, i);
        }

        AddAlbumItemToRow((pictures.Count - 1) * 2);
    }

    private void AddSepartorToRow(Separator separator, int i)
    {
        Grid.SetRow(separator, i * 2 + 1);
        Grid.SetColumn(separator, i * 2 + 1);

        ItemsGrid.Children.Add(separator);
    }

    private void AddAlbumItemToRow(int i)
    {
        var albumItem = new AlbumItem();

        Grid.SetRow(albumItem, i * 2);
        Grid.SetColumn(albumItem, i * 2);

        ItemsGrid.Children.Add(albumItem);
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