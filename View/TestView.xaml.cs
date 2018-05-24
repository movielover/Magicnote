using System.Windows;
using System.Windows.Controls;
using ViewModel;

namespace View
{
    public partial class TestView
    {
        private readonly NoteViewModel _noteViewModel = new NoteViewModel();

        public TestView(int pkPId)
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new NoteViewModel();
            _noteViewModel.GetParagraph(pkPId);
        }

        private void RichTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //    private void RichTextBox_OnTextChanged(object sender, TextChangedEventArgs e)
        //    {
        //        TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
        //    }
        //}
        //private string StringFromRichTextBox(RichTextBox rtb)
        //    {
        //        TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
        //        //string noteText = textRange.Text;
        //        int paragraphNumber = 1;
        //        _noteViewModel.SaveNoteToDb(textRange.Text, paragraphNumber);
        //        return textRange.Text;
    }
}

