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

    public static DependencyProperty SourceProperty = DependencyProperty.Register("Source", typeof(List<Picture>), typeof(EditAlbumView), new PropertyMetadata(new List<Picture>(), OnSourceChanged));
    
    public List<Picture> Source
    {
        get { return (List<Picture>)base.GetValue(SourceProperty); }
        set { base.SetValue(SourceProperty, value); }
    }
    
    private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        var panel = d as EditAlbumView;
        panel?.RefreshAlbumItems(e.NewValue as List<Picture>);
    }

    private void RefreshAlbumItems(List<Picture> pictures)
    {
        
        
        var albumItem = new AlbumItem();
        
        Grid.SetRow(albumItem, 0);
        Grid.SetColumn(albumItem, 0);

        MainGrid.Children.Add(albumItem);
    }
}