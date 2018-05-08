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
using System.Windows.Shapes;
using Magicnote.ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for ParagraphView.xaml
    /// </summary>
    public partial class ParagraphView : Window
    {
        MainViewModel _mainViewModel = new MainViewModel();
        public ParagraphView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }


        private string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                // TextPointer to the start of content in the RichTextBox.
                rtb.Document.ContentStart,
                // TextPointer to the end of content in the RichTextBox.
                rtb.Document.ContentEnd
            );

            // The Text property on a TextRange object returns a string
            // representing the plain text content of the TextRange.
            var noteText = textRange.Text;
            _mainViewModel.SaveNoteToDB(noteText);
            return textRange.Text;
            
        }
    }
}
