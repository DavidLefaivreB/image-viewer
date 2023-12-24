using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ImageBrowser.Ui.Component;

public partial class CategoryPanel
{
    public CategoryPanel()
    {
        InitializeComponent();
    }

    public void UpdateAvailableCategories(List<string> categories)
    {
        CategoryGrid.RowDefinitions.Clear();

        var nbRows = Math.Ceiling(categories.Count / 2.0);
        for (var i = 0; i < nbRows; ++i)
        {
            CategoryGrid.RowDefinitions.Add(new RowDefinition());
        }

        for (var i = 0; i < categories.Count; ++i)
        {
            var column = (i % 2 == 0) ? 1 : 2;
            var row = (int)Math.Floor(i / 2.0);

            AddCategoryCheckbox(categories[i], column, row);
        }
    }

    private void AddCategoryCheckbox(String content, int column, int row)
    {
        CheckBox categoryCheckBox = new CheckBox();
        categoryCheckBox.Checked += OnChecked;
        categoryCheckBox.Unchecked += OnUnchecked;
        categoryCheckBox.Content = content;
        categoryCheckBox.Style = (Style)FindResource("CheckBoxStyle");

        Grid.SetColumn(categoryCheckBox, column);
        Grid.SetRow(categoryCheckBox, row);

        CategoryGrid.Children.Add(categoryCheckBox);
    }

    private void OnChecked(object sender, RoutedEventArgs e)
    {
        CategoryChecked?.Invoke(sender);
    }
    
    private void OnUnchecked(object sender, RoutedEventArgs e)
    {
        CategoryUnchecked?.Invoke(sender);
    }
    
    public delegate void CheckBoxSelection(object sender);

    public event CheckBoxSelection CategoryChecked;
    public event CheckBoxSelection CategoryUnchecked;
}