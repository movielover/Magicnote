using Magicnote.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Magicnote.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;
        public SubLegalArea SubLegalArea;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Note> Notes { get; set; }
        public List<MainLegalArea> MainLegalAreas { get; }
        public List<SubLegalArea> SubLegalAreas { get; set; }
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
            DbManager.GetSubAreas(number);
            SubLegalAreas = DbManager.GetSubAreas(1);
        }

        public void GetParagraphs(int i)
        {
            Paragraphs = DbManager.GetParagraphs(i);
        }

        public void AddNote(string noteText, int paragraphId, DateTime dateTime)
        {
            DbManager.AddNote(noteText, paragraphId, dateTime);
        }


        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public void CreateParagraph(int ParagraphNumber, string Headline, string Lawtext, int FK_SA_ID)
        {
            DbManager.CreateParagraph(ParagraphNumber, Headline, Lawtext, FK_SA_ID);
        }
        public void CreateNote(string NoteText, DateTime NoteDate, int FK_P_ID)
        {
            DbManager.CreateNote(NoteText, NoteDate, FK_P_ID);
        }

        public void GetNoteDB(int id)
        {

        }

        public void SaveNoteToDB(string noteText, int paragraphNumber)
        {
            int id;
            DbManager.SaveNote(noteText, paragraphNumber);
        }

    }
}
