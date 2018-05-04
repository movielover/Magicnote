using Magicnote.ViewModel;
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
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new MainViewModel();
        }

        private void MakeNote_OnClick(object sender, RoutedEventArgs e)
        {
            CreateNoteView createNoteView = new CreateNoteView();
            createNoteView.Show();
            this.Close();
        }


        private void GetToMenu_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
