using System;
using System.Windows;
using System.Windows.Controls;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for OpretParagraf.xaml
    /// </summary>
    public partial class CreateParagraphView
    {
        private readonly CreateParagraphViewModel _createParagraphViewModel;

        public CreateParagraphView(CreateParagraphViewModel createParagraphViewModel)
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new CreateParagraphViewModel();
            _createParagraphViewModel = createParagraphViewModel;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            int subAreaId = Convert.ToInt32(comboBox.Tag);
            _createParagraphViewModel.GetSubLegalArea(subAreaId);
        }
    }
}
