using System.Windows;
using ViewModel;


namespace View
{
    /// <summary>
    /// Interaction logic for ParagraphView.xaml
    /// </summary>
    public partial class NoteView3 : Window
    {
        public NoteView3(int pkPId)
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new NoteViewModel();
            NoteViewModel.GetDateForParagraph(pkPId);


        }


        //private string StringFromRichTextBox(RichTextBox rtb)
        //{
        //    TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
        //    //string noteText = textRange.Text;
        //    int paragraphNumber = 1;
        //    MainViewModel.SaveNoteToDb(textRange.Text, paragraphNumber);
        //    return textRange.Text;

    }


}


