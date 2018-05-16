using System;
using System.Windows;
using System.Windows.Controls;
using DevExpress.Mvvm.POCO;
using ViewModel;


namespace View
{
    /// <summary>
    /// Interaction logic for OpretParagraf.xaml
    /// </summary>
    public partial class CreateParagraph
    {
        private readonly MainViewModel _mainViewModel = new MainViewModel();

        public CreateParagraph()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new MainViewModel();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox button = (ComboBox)sender;
            int subAreaId = Convert.ToInt32(button.Tag);
            _mainViewModel.GetSubLegalArea(subAreaId);
            
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
