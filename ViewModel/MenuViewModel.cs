﻿using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;

namespace ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        private readonly DbManager _dbManager;
        private readonly Paragraph _paragraph;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<MainLegalArea> MainLegalAreas { get; }

        private List<SubLegalArea> _subLegalAreas;

        public List<SubLegalArea> SubLegalAreas
        {
            get => _subLegalAreas;

            set
            {
                _subLegalAreas = value;
                OnPropertyChanged(nameof(SubLegalAreas));
            }
        }

        private List<Paragraph> _paragraphs { get; set; }

        public List<Paragraph> Paragraphs
        {
            get => _paragraphs;

            set
            {
                _paragraphs = value;
                OnPropertyChanged(nameof(Paragraphs));
            }
        }

        public MenuViewModel()
        {
            _dbManager = new DbManager();
            MainLegalAreas = _dbManager.GetMainLegalAreas();
            _subLegalAreas = new List<SubLegalArea>();
            _paragraph = new Paragraph();
        }

        public void GetSubLegalArea(int number)
        {
            SubLegalAreas = _dbManager.GetSubAreas(number);
        }

        public void GetParagraphs(int paragraphNumber)
        {
            Paragraphs = _dbManager.GetParagraphs(paragraphNumber);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}