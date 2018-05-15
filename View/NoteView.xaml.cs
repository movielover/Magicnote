using Magicnote.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace View
{
    /// <summary>
    /// Interaction logic for ParagraphView.xaml
    /// </summary>
    public partial class ParagraphView : Window
    {
        public readonly MainViewModel MainViewModel = new MainViewModel();
        public ParagraphView()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new MainViewModel();
        }


        private string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            //string noteText = textRange.Text;
            int paragraphNumber = 1;
            MainViewModel.SaveNoteToDb(textRange.Text, paragraphNumber);
            return textRange.Text;

        }

        private void ParagraphEdit_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
