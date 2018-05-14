using Magicnote.ViewModel;
using System.Windows;


namespace View
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu
    {
        private readonly MainViewModel _mainViewModel = new MainViewModel();
        public Menu()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new MainViewModel();
        }

        //private void Label_MainArea_OnMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    Label label = (Label) sender;
        //    int subAreaId = Convert.ToInt32(label.Tag);
        //    _mainViewModel.GetSubLegalArea(subAreaId);
        //}

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {

            SubMenu subMenu = new SubMenu();
            subMenu.Show();
            Close();

            //Button button = (Button)sender;
            //int subAreaId = Convert.ToInt32(button.Tag);
            //_mainViewModel.GetSubLegalArea(subAreaId);
            //Sub_List_View.Items.Refresh();
        }

        private void Paragraph_View_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            
        }

        //private void ButtonBase1_OnClick(object sender, RoutedEventArgs e)
        //{
        //    Button button = (Button)sender;
        //    int paragraphId = Convert.ToInt32(button.Tag);
        //    _mainViewModel.GetParagraphs(paragraphId);
        //}
    }
}
