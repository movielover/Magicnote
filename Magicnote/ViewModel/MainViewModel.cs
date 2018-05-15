﻿using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Magicnote.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;
        public SubLegalArea SubLegalArea;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Note { get; set; }
        public List<MainLegalArea> MainLegalAreas { get; }

        public List<SubLegalArea> SubLegalAreas
        {
            get => SubLegalAreas;

            set
            {
                SubLegalAreas = value;
                OnPropertyChanged("SubLegalAreas");
            }
        }

        public List<Paragraph> Paragraphs { get; set; }


        public MainViewModel()
        {
            DbManager = new DbManager();
            SubLegalArea = new SubLegalArea();
            MainLegalAreas = DbManager.GetMainLegalAreas();

        }
        public void GetSubLegalArea(int number)
        {
            SubLegalAreas = DbManager.GetSubAreas(number).ToList();
        }

        public void GetParagraphs(int paragraphNumber)
        {
            Paragraphs = DbManager.GetParagraphs(paragraphNumber);
        }

        public void AddNote(string noteText, int paragraphId)
        {
            DbManager.CreateNote(noteText, paragraphId);
        }

        public void GetNoteDb(int paragraphNumber)
        {
            Note = DbManager.GetNote(paragraphNumber);
        }

        public void SaveNoteToDb(string noteText, int paragraphNumber)
        {
            DbManager.SaveNote(noteText, paragraphNumber);
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
