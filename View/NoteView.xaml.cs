
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using ViewModel;


namespace View
{
    /// <summary>
    /// Interaction logic for NoteView2.xaml
    /// </summary>
    public partial class NoteView : Window
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
