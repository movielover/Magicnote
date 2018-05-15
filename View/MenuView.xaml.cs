using Magicnote.Domain;
using Magicnote.ViewModel;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;


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

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            SubListView.ItemsSource = null;

            Button button = (Button)sender;
            int subAreaId = Convert.ToInt32(button.Tag);



            _mainViewModel.GetSubLegalArea(subAreaId);


            SubListView.Items.Refresh();
        }

        private void ButtonBase1_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int paragraphId = Convert.ToInt32(button.Tag);
            _mainViewModel.GetParagraphs(paragraphId);
        }
    }
}
