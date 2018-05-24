using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using ViewModel;


namespace View
{
    /// <summary>
    /// Interaction logic for ParagraphView.xaml
    /// </summary>
    public partial class NoteView3 : Window
    {
        private readonly NoteViewModel _noteViewModel = new NoteViewModel();


        public NoteView3(int pkPId)
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new NoteViewModel();
            _noteViewModel.GetParagraph(pkPId);


        }


        private string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            //string noteText = textRange.Text;
            int paragraphNumber = 1;
            _noteViewModel.SaveNoteToDb(textRange.Text, paragraphNumber);
            return textRange.Text;

        }


    }
}


