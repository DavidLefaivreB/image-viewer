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

            CheckBox checkBoxNormal = new CheckBox();
            checkBoxNormal.Checked += OnCheckBoxChecked;
            checkBoxNormal.Unchecked += OnCheckBoxUnchecked;
            checkBoxNormal.Content = "Normal";
            checkBoxNormal.Style = (Style)FindResource("CheckBoxStyle");
            
            CheckBox checkBoxLingerie = new CheckBox();
            checkBoxLingerie.Checked += OnCheckBoxChecked;
            checkBoxLingerie.Unchecked += OnCheckBoxUnchecked;
            checkBoxLingerie.Content = "Lingerie";
            checkBoxLingerie.Style = (Style)FindResource("CheckBoxStyle");
            
            CheckBox checkBoxBottomless = new CheckBox();
            checkBoxBottomless.Checked += OnCheckBoxChecked;
            checkBoxBottomless.Unchecked += OnCheckBoxUnchecked;
            checkBoxBottomless.Content = "Bottomless";
            checkBoxBottomless.Style = (Style)FindResource("CheckBoxStyle");
            
            CheckBox checkBoxTopless = new CheckBox();
            checkBoxTopless.Checked += OnCheckBoxChecked;
            checkBoxTopless.Unchecked += OnCheckBoxUnchecked;
            checkBoxTopless.Content = "Topless";
            checkBoxTopless.Style = (Style)FindResource("CheckBoxStyle");
            
            CheckBox checkBoxNude = new CheckBox();
            checkBoxNude.Checked += OnCheckBoxChecked;
            checkBoxNude.Unchecked += OnCheckBoxUnchecked;
            checkBoxNude.Content = "Nude";
            checkBoxNude.Style = (Style)FindResource("CheckBoxStyle");
            
            CheckBox checkBoxPubes = new CheckBox();
            checkBoxPubes.Checked += OnCheckBoxChecked;
            checkBoxPubes.Unchecked += OnCheckBoxUnchecked;
            checkBoxPubes.Content = "Pubes";
            checkBoxPubes.Style = (Style)FindResource("CheckBoxStyle");
            
            CheckBox checkBoxTanline = new CheckBox();
            checkBoxTanline.Checked += OnCheckBoxChecked;
            checkBoxTanline.Unchecked += OnCheckBoxUnchecked;
            checkBoxTanline.Content = "Tanline";
            checkBoxTanline.Style = (Style)FindResource("CheckBoxStyle");
            
            CheckBox checkBoxCum = new CheckBox();
            checkBoxCum.Checked += OnCheckBoxChecked;
            checkBoxCum.Unchecked += OnCheckBoxUnchecked;
            checkBoxCum.Content = "Cum";
            checkBoxCum.Style = (Style)FindResource("CheckBoxStyle");
            
            CheckBox checkBoxAlternate = new CheckBox();
            checkBoxAlternate.Checked += OnCheckBoxChecked;
            checkBoxAlternate.Unchecked += OnCheckBoxUnchecked;
            checkBoxAlternate.Content = "Alternate";
            checkBoxAlternate.Style = (Style)FindResource("CheckBoxStyle");
            
            Grid.SetColumn(checkBoxNormal, 1);
            Grid.SetRow(checkBoxNormal, 0);
            
            Grid.SetColumn(checkBoxLingerie, 2);
            Grid.SetRow(checkBoxLingerie, 0);
            
            Grid.SetColumn(checkBoxBottomless, 1);
            Grid.SetRow(checkBoxBottomless, 1);

            Grid.SetColumn(checkBoxTopless, 2);
            Grid.SetRow(checkBoxTopless, 1);
            
            Grid.SetColumn(checkBoxNude, 1);
            Grid.SetRow(checkBoxNude, 2);
                
            Grid.SetColumn(checkBoxPubes, 2);
            Grid.SetRow(checkBoxPubes, 2);
                
            Grid.SetColumn(checkBoxTanline, 1);
            Grid.SetRow(checkBoxTanline, 3);
                
            Grid.SetColumn(checkBoxCum, 2);
            Grid.SetRow(checkBoxCum, 3);
                
            Grid.SetColumn(checkBoxAlternate, 1);
            Grid.SetRow(checkBoxAlternate, 4);
            
            CategoryGrid.Children.Add(checkBoxNormal);
            CategoryGrid.Children.Add(checkBoxLingerie);
            CategoryGrid.Children.Add(checkBoxBottomless);
            CategoryGrid.Children.Add(checkBoxTopless);
            CategoryGrid.Children.Add(checkBoxNude);
            CategoryGrid.Children.Add(checkBoxPubes);
            CategoryGrid.Children.Add(checkBoxTanline);
            CategoryGrid.Children.Add(checkBoxCum);
            CategoryGrid.Children.Add(checkBoxAlternate);
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