using System;
using System.Windows;
using System.Windows.Controls;
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
            DataContext = _mainViewModel;
        }

        private void Select_SubArea_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void MainAreas_OnDropDownClosed(object sender, EventArgs e)
        {
            
            ComboBox button = (ComboBox)sender;
            int subAreaId = Convert.ToInt32(MainAreas.SelectedValue);


            _mainViewModel.GetSubLegalArea(subAreaId);



            SubAreas.Items.Refresh();
        }
    }

        
    }
