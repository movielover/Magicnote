using Magicnote.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ParagraphView : Window
    {
        public ParagraphView()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }
        string StringFromRichTextBox(RichTextBox rtb)
        {
            TextRange textRange = new TextRange(
                // TextPointer to the start of content in the RichTextBox.
                rtb.Document.ContentStart,
                // TextPointer to the end of content in the RichTextBox.
                rtb.Document.ContentEnd
            );

            // The Text property on a TextRange object returns a string
            // representing the plain text content of the TextRange.
            return textRange.Text;
        }
        private void ButtonImage_OnClick(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog 
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".png",
                Filter =
                    "Image files (*.png;*.jpeg;*.jpg;*.gif)|*.png;*.jpeg;*.jpg;*.gif|" +
                    "PNG Files (*.png)|*.png|" +
                    "JPEG Files (*.jpeg)|*.jpeg|" +
                    "JPG Files (*.jpg)|*.jpg|" +
                    "GIF Files (*.gif)|*.gif|" +
                    "All files (*.*)|*.*"
            };

            // Display OpenFileDialog by calling ShowDialog method 
            bool? result = dlg.ShowDialog();


            // Get the selected file name and display in a TextBox 
            if (result != true) return;
            // Open document
            ImageBox.Source = new ImageSourceConverter().ConvertFromString(dlg.FileName) as ImageSource;
        }
    }
}

