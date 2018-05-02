using Magicnote.ViewModel;
using System.Windows;
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

