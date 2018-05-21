using System.Windows;
using ViewModel;



namespace View
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new MenuViewModel();
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
    }
}
