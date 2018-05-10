﻿using Magicnote.ViewModel;
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
            TextRange textRange = new TextRange(
                // TextPointer to the start of content in the RichTextBox.
                rtb.Document.ContentStart,
                // TextPointer to the end of content in the RichTextBox.
                rtb.Document.ContentEnd
            );

            // The Text property on a TextRange object returns a string
            // representing the plain text content of the TextRange.
            string noteText = textRange.Text;
            int paragraphNumber = 1;
            MainViewModel.SaveNoteToDB(noteText, paragraphNumber);
            return textRange.Text;

        }

        private void ParagraphEdit_OnClick(object sender, RoutedEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
