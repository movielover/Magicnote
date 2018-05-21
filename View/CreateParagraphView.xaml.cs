﻿using System;
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
        private MainViewModel _mainViewModel;

        public CreateParagraphView()
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
    }
}
