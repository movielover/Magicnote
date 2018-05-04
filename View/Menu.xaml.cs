using System;
using Magicnote.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace View
{
    /// <summary>
    /// Interaction logic for Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        MainViewModel mainViewModel = new MainViewModel();
        public Menu()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }


        private void LabelSubArea(object sender, MouseButtonEventArgs e)
        {
            Label label = (Label)sender;
            int subAreaId = Convert.ToInt16(label.Tag);
            mainViewModel.GetSubLegalArea(subAreaId);
        }
    }
}
