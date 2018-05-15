using Magicnote.Domain;
using System;
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

        public List<Note> Notes { get; set; }
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
            //SubLegalAreas = DbManager.GetSubAreas(1);

        }
        public void GetSubLegalArea(int number)
        {
            SubLegalAreas = DbManager.GetSubAreas(number).ToList();
        }

        public void GetParagraphs(int i)
        {
            Paragraphs = DbManager.GetParagraphs(i);
        }

        public void AddNote(string noteText, int paragraphId, DateTime dateTime)
        {
            DbManager.AddNote(noteText, paragraphId, dateTime);
        }

        public void GetNoteDB(int id)
        {

        }

        public void SaveNoteToDB(string noteText, int paragraphNumber)
        {
            int id;
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
