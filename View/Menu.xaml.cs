using Magicnote.ViewModel;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


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
            //    Label label = (Label)sender;
            //    int subAreaId = Convert.ToInt16(label.Tag);
            //    _mainViewModel.GetSubLegalArea(subAreaId);
            //    MainWindow mainWindow = new MainWindow();
            //    mainWindow.Show();
            //    Close();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int subAreaId = Convert.ToInt32(button.Tag);
            _mainViewModel.GetSubLegalArea(subAreaId);
        }
    }
}
