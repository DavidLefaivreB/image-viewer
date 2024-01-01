using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

namespace ImageBrowser.Ui.Component.Tags;

public partial class TagPanel
{
    public TagPanel()
    {
        InitializeComponent();
    }
    
    public static readonly DependencyProperty SourceProperty = DependencyProperty.Register(nameof(Source), typeof(List<string>), typeof(TagPanel), new PropertyMetadata(new List<string>(), OnSourceChanged));
    public static readonly DependencyProperty TitleProperty = DependencyProperty.Register(nameof(Title), typeof(string), typeof(TagPanel), new PropertyMetadata("", OnTitleChanged));
   
    public List<string> Source
    {
        get => (List<string>)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    public string Title
    {
        get => (string)GetValue(SourceProperty);
        set => SetValue(SourceProperty, value);
    }

    private void OnTexBoxKeyDownHandler(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Return)
            AddTag();
    }

    private void AddTag()
    {
        CreateNewTag();
        TagAdded?.Invoke(ValueTextBox.Text);

        ValueTextBox.Text = "";
    }

    private void CreateNewTag()
    {
        var tag = new Tag(ValueTextBox.Text);
        tag.OnDeletePressed += () => RemoveTag(tag);
        TagsContainer.Children.Add(tag);
    }

    private void RemoveTag(Tag tag)
    {
        TagsContainer.Children.Remove(tag);
        TagRemoved?.Invoke(tag.Title.Content);
    }
    
    private static void OnSourceChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is TagPanel panel)
            panel!.ValueTextBox.SuggestionValues = e.NewValue as List<string>;
    }

    private static void OnTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is TagPanel panel)
            panel!.TitleLabel.Content = e.NewValue as string;
    }
    
    public delegate void TagUpdated(object sender);

    public event TagUpdated TagAdded;
    public event TagUpdated TagRemoved;
}