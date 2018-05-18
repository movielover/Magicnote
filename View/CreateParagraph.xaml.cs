﻿using System;
using System.Runtime.InteropServices;
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

        
        private void MainAreas_OnDropDownClosed(object sender, EventArgs e)
        {
            
            
            int subAreaId = Convert.ToInt32(MainAreas.SelectedValue);


            _mainViewModel.GetSubLegalArea(subAreaId);
            SubId.Items.Refresh();
        }

       

        private void Paragraf_Number_OnLostFocus(object sender, RoutedEventArgs e)
        {
            
            PNumber = Convert.ToInt32(ParagraphNumberTextBox.Text);
            

        }

        private void Lawtext_OnLostFocus(object sender, RoutedEventArgs e)
        {
            LawText = LawTextTextBox.Text;
        }

        public void HeadLine_OnLostFocus(object sender, RoutedEventArgs e)
        {
            HeadLine = HeadLineTextBox.Text;
        }

        private void AddParagraph()
        {
             _mainViewModel.CreateParagraphAndNote(PNumber, HeadLine, LawText, Id);
        }

        public int Id { get; set; }

        public string HeadLine { get; set; }

        public int PNumber { get; set; }
        public string LawText { get; private set; }

        private void Videre_OnClick(object sender, RoutedEventArgs e)
        {
            AddParagraph();
        }


        private void SubId_OnDropDownClosed(object sender, EventArgs e)
        {
            int subId = Convert.ToInt32(SubId.SelectedValue);
            Id = subId;
        }
    }

        
    }
