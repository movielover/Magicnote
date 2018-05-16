using ViewModel;
using System.Windows;


namespace View
{
    /// <summary>
    /// Interaction logic for SubMenu.xaml
    /// </summary>
    public partial class SubMenu : Window
    {
        private MainViewModel _mainViewModel = new MainViewModel();

        public SubMenu()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new MainViewModel();
            _mainViewModel.GetSubLegalArea(1);
        }

        private void ButtonBaseOpenParagraph(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close();
        }

        private void BackToMenu(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            Close();
        }
    }
}
