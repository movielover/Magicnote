﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ViewModel;

namespace View
{
    /// <summary>
    /// Interaction logic for TestView.xaml
    /// </summary>
    public partial class TestView : Window
    {
        private readonly NoteViewModel _noteViewModel = new NoteViewModel();

        public TestView(int pkPId)
        {
            DataContext = new NoteViewModel();
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            _noteViewModel.GetParagraph(pkPId);
        }
    }
}
