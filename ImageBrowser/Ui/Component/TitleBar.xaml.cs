using System.Windows;
using System.Windows.Controls;

namespace ImageBrowser.Ui.Component
{
    public partial class TitleBar : UserControl
    {
        public TitleBar()
        {
            InitializeComponent();
            DataContext = this;
        }

        public string Icon { get; set; }
        public string Title { get; set; }
        public int MaxLength { get; set; }

        private void OnCloseButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void OnMinimizeButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            Window.GetWindow(this).WindowState = WindowState.Minimized;
        }

        private void OnMaximizeButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            Window window = Window.GetWindow(this);

            if (window.WindowState == WindowState.Maximized)
            {
                window.WindowState = WindowState.Normal;
            }
            else
            {
                window.WindowState = WindowState.Maximized;
            }
        }
    }
}
