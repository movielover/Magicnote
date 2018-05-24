using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Shapes;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : Window
    {
        private readonly NoteViewModel _noteViewModel = new NoteViewModel();

        public TestView(int pkPId)
        {
            DataContext = new NoteViewModel();
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _noteViewModel.GetParagraph(pkPId);
        }

        private string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(rtb.Document.ContentStart, rtb.Document.ContentEnd);
            //string noteText = textRange.Text;
            int paragraphNumber = 1;
            _noteViewModel.SaveNoteToDb(textRange.Text, paragraphNumber);
            return textRange.Text;

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
    }

