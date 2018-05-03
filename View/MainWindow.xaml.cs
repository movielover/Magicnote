using System.Windows;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MakeNote_OnClick(object sender, RoutedEventArgs e)
        {
            CreateNoteView note = new CreateNoteView();
            note.Show();
            this.Close();
        }


        private void GetToMenu_Click(object sender, RoutedEventArgs e)
        {
            ParagraphView paragraphView = new ParagraphView();
            paragraphView.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
