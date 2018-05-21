using System;
using System.Windows;
using System.Windows.Controls;
using ViewModel;


namespace View
{
    public partial class MenuView
    {
        private readonly MenuViewModel _menuViewModel = new MenuViewModel();
        public MenuView()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = _menuViewModel;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void GetSubArea_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int mainAreaId = Convert.ToInt32(button.Tag);
            _menuViewModel.GetSubLegalArea(mainAreaId);
            SubListView.Items.Refresh();
        }

        private void GetParagraphs_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int subAreaId = Convert.ToInt32(button.Tag);
            _menuViewModel.GetParagraphs(subAreaId);
            ParagraphView.Items.Refresh();

        }
        private void GetToNote_Click(object sender, RoutedEventArgs e)
        {
            NoteView noteView = new NoteView();
            noteView.Show();
            Close();
        }
    }
}
