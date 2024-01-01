using System.Windows.Controls;
using System.Windows.Input;

namespace ImageBrowser.Ui.Component.Tags
{
    public partial class Tag : UserControl
    {
        public Tag() : this("")
        {
        }

        public Tag(string title)
        {
            InitializeComponent();
            Title.Content = title;
        }

        public delegate void DeletePressed();

        public DeletePressed OnDeletePressed;
        
        private  void DeleteTag(object sender, MouseButtonEventArgs e)
        {
            OnDeletePressed?.Invoke();
        }
    }
}