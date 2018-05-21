using System.Windows;


namespace View
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void MakeNote_OnClick(object sender, RoutedEventArgs e)
        {
            CreateParagraphView createParagraphView = new CreateParagraphView();
            createParagraphView.Show();
            Close();
        }


        private void GetToMenu_OnClick(object sender, RoutedEventArgs e)
        {
            MenuView menuView = new MenuView();
            menuView.Show();
            Close();
        }
    }
}
