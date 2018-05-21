using System.Windows;
using ViewModel;



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
            DataContext = new MainWindowViewModel();
        }

        

        private void MakeNote_OnClick(object sender, RoutedEventArgs e)
        {
            CreateParagraphView createParagraphView = new CreateParagraphView();
            createParagraphView.Show();
            Close();
        }


        private void GetToMenu_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
