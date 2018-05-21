using System;
using System.Windows;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for OpretParagraf.xaml
    /// </summary>
    public partial class CreateParagraphView
    {
        private readonly CreateParagraphViewModel _createParagraphViewModel = new CreateParagraphViewModel();

        public int Id { get; set; }

        public string HeadLine { get; set; }

        public int PNumber { get; set; }
        public string LawText { get; set; }

        public CreateParagraphView()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = _createParagraphViewModel;
        }

        private void MainAreas_OnDropDownClosed(object sender, EventArgs e)
        {
            int mainAreaId = Convert.ToInt32(MainAreas.SelectedValue);
            _createParagraphViewModel.GetSubLegalArea(mainAreaId);
            SubId.Items.Refresh();
        }


        private void SubId_OnDropDownClosed(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(SubId.SelectedValue);
        }

        private void AddParagraph()
        {
            _createParagraphViewModel.CreateParagraphAndNote(PNumber, HeadLine, LawText, Id);
        }

        private void Videre_OnClick(object sender, RoutedEventArgs e)
        {
            AddParagraph();
        }

        private void LawTextTextBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            LawText = LawTextTextBox.Text;
        }

        private void HeadLineTextBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            HeadLine = HeadLineTextBox.Text;
        }

        private void ParagraphNumberTextBox_OnLostFocus(object sender, RoutedEventArgs e)
        {
            PNumber = Convert.ToInt32(ParagraphNumberTextBox.Text);
        }
    }
}
