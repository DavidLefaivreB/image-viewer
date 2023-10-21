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