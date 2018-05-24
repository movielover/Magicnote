using System.Windows.Controls;
using System.Windows.Documents;
using ViewModel;


namespace View
{
    public partial class NoteView
    {
        public NoteView()
        {
            InitializeComponent();
            DataContext = new NoteViewModel();
        }

        private string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            int paragraphNumber = ParagraphNumber;
            NoteViewModel.SaveNoteToDb(textRange.Text, paragraphNumber);
            return textRange.Text;
        }

        public int ParagraphNumber { get; set; }


    }
}
