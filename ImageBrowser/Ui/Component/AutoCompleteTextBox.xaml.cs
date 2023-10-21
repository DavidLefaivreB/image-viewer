using System.Linq;
using System.Windows.Controls;

namespace ImageBrowser.Ui.Component
{
    public partial class AutoCompleteTextBox : TextBox
    {
        public AutoCompleteTextBox()
        {
            InitializeComponent();
            SuggestionValues = new string[]{};
        }

        public string[] SuggestionValues { private get; set; }

        private string _currentInput = "";
        private string _currentSuggestion = "";
        private string _currentText = "";

        private int _selectionStart;
        private int _selectionLength;

        private void AutoCompleteTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            {
                var input = AutoCompleteBox.Text;
                if (input.Length > _currentInput.Length && input != _currentSuggestion)
                {
                    _currentSuggestion = SuggestionValues.FirstOrDefault(x => x.StartsWith(input));
                    if (_currentSuggestion != null)
                    {
                        _currentText = _currentSuggestion;
                        _selectionStart = input.Length;
                        _selectionLength = _currentSuggestion.Length - input.Length;

                        AutoCompleteBox.Text = _currentText;
                        AutoCompleteBox.Select(_selectionStart, _selectionLength);
                    }
                }

                _currentInput = input;
            }
        }
    }
}