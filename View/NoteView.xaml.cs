using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using ViewModel;

namespace View
{
    public partial class NoteView
    {
        private readonly NoteViewModel _noteViewModel = new NoteViewModel();

        public NoteView(int pkPId)
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = _noteViewModel;
            _noteViewModel.GetParagraphsToNote(pkPId);
        }

        //private string StringFromRichTextBox(RichTextBox rtb)
        //{
        //    TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
        //    //string noteText = textRange.Text;
        //    int paragraphNumber = 1;
        //    _noteViewModel.SaveNoteToDb(textRange.Text, paragraphNumber);
        //    return textRange.Text;

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
    

