using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ImageBrowser.Controller;
using ImageBrowser.Ui.Component;

namespace ImageBrowser.Ui
{
    public partial class RightPanel
    {
        private ThumbnailsController _thumbnailsController;

        public RightPanel()
        {
            InitializeComponent();

            CategoryGrid.RowDefinitions.Clear();

            for (var i = 0; i < 5; ++i)
            {
                CategoryGrid.RowDefinitions.Add(new RowDefinition());
            }

            AddCategoryCheckbox("Normal", 1, 0);
            AddCategoryCheckbox("Lingerie", 2, 0);
            AddCategoryCheckbox("Bottomless", 1, 1);
            AddCategoryCheckbox("Topless", 2, 1);
            AddCategoryCheckbox("Nude", 1, 2);
            AddCategoryCheckbox("Pubes", 2, 2);
            AddCategoryCheckbox("Tanline", 1, 3);
            AddCategoryCheckbox("Cum", 2, 3);
            AddCategoryCheckbox("Alternate", 1, 4);
        }

        private void AddCategoryCheckbox(String content, int column, int row)
        {
            CheckBox categoryCheckBox = new CheckBox();
            categoryCheckBox.Checked += OnCheckBoxChecked;
            categoryCheckBox.Unchecked += OnCheckBoxUnchecked;
            categoryCheckBox.Content = content;
            categoryCheckBox.Style = (Style)FindResource("CheckBoxStyle");

            Grid.SetColumn(categoryCheckBox, column);
            Grid.SetRow(categoryCheckBox, row);

            CategoryGrid.Children.Add(categoryCheckBox);
        }

        public void SetPictureRepository(ThumbnailsController thumbnailsController)
        {
            _thumbnailsController = thumbnailsController;
        }

        private void OnCheckBoxChecked(object sender, RoutedEventArgs e)
        {
            _thumbnailsController.AddCategory(((CheckBox)sender).Content.ToString());
        }

        private void OnCheckBoxUnchecked(object sender, RoutedEventArgs e)
        {
            _thumbnailsController.RemoveCategory(((CheckBox)sender).Content.ToString());
        }

        private void OnFranchiseKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
                AddFranchise();
        }

        private void AddFranchise()
        {
            CreateNewTag();
            _thumbnailsController.AddFranchise(FranchiseTextBox.Text);

            FranchiseTextBox.Text = "";
        }

        private void CreateNewTag()
        {
            var tag = new Tag(FranchiseTextBox.Text);
            tag.OnDeletePressed += () => RemoveFranchise(tag);
            TagsContainer.Children.Add(tag);
        }

        private void RemoveFranchise(Tag tag)
        {
            TagsContainer.Children.Remove(tag);
            _thumbnailsController.RemoveFranchise((string)tag.Title.Content);
        }

        public void UpdateAvailableFranchises(List<string> retrieveAll)
        {
            FranchiseTextBox.SuggestionValues = retrieveAll;
        }
    }
}