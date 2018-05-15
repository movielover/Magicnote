using System;
using System.Windows;
using System.Windows.Controls;

namespace View
{
    /// <summary>
    /// Interaction logic for OpretParagraf.xaml
    /// </summary>
    public partial class CreateParagraph
    {
        private MainViewModel.MainViewModel _mainViewModel;

        public CreateParagraph()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new MainViewModel.MainViewModel();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox button = (ComboBox)sender;
            int subAreaId = Convert.ToInt32(button.Tag);
            _mainViewModel.GetSubLegalArea(subAreaId);
        }
    }
}
