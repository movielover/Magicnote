using System;
using System.Windows;
using System.Windows.Controls;
using ViewModel;


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
            DataContext = _mainViewModel;
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void GetSubArea_OnClick(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int subAreaId = Convert.ToInt32(button.Tag);


            _mainViewModel.GetSubLegalArea(subAreaId);



            SubListView.Items.Refresh();
        }

        private void GetParagraphs_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            int paragraphId = Convert.ToInt32(button.Tag);
            _mainViewModel.GetParagraphs(paragraphId);
            ParagraphView.Items.Refresh();

        }
        private void GetToNote_Click(object sender, RoutedEventArgs e)
        {
            NoteView noteView = new NoteView();
            noteView.Show();
            this.Close();
        }
    }
}
