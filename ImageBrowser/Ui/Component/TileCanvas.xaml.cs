using System;
using System.Windows;
using System.Windows.Controls;

namespace ImageBrowser.Ui.Component
{
    public partial class TileCanvas
    {
        public TileCanvas()
        {
            InitializeComponent();
        }

        private void onControlSizeChanged(object sender, SizeChangedEventArgs e)
        {
            Console.WriteLine(e.NewSize.Width + " x " + e.NewSize.Height);
        }
    }
}