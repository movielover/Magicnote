using Magicnote.Domain;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;
        public SubLegalArea SubLegalArea;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Note { get; set; }
        public List<MainLegalArea> MainLegalAreas { get; }

        private List<SubLegalArea> _subLegalAreas;


        public List<SubLegalArea> SubLegalAreas
        {
            get => _subLegalAreas;

            set
            {
                _subLegalAreas = value;
                OnPropertyChanged("SubLegalAreas");
            }
        }

        public List<Paragraph> Paragraphs { get; set; }


        public MainViewModel()
        {
            DbManager = new DbManager();
            SubLegalArea = new SubLegalArea();
            MainLegalAreas = DbManager.GetMainLegalAreas();
            _subLegalAreas = new List<SubLegalArea>();

            GetParagraphs(1);
            GetNote(1);

        }

        public void GetSubLegalArea(int number)
        {
            SubLegalAreas = new List<SubLegalArea>(DbManager.GetSubAreas(number).ToList());
        }

        public void GetParagraphs(int paragraphNumber)
        {
            Paragraphs = DbManager.GetParagraphs(paragraphNumber);
        }


        //public void AddNote(string noteText, int paragraphId)
        //{
        //    DbManager.CreateNote(noteText, paragraphId);
        //}

        public void SaveNote(string noteText, int paragraphId)
        {
            DbManager.SaveNote(noteText, paragraphId);
        }


        public void GetNote(int paragraphNumber)
        {
            Note = DbManager.GetNote(paragraphNumber);
        }

        public void SaveNoteToDb(string noteText, int paragraphNumber)
        {
            DbManager.SaveNote(noteText, paragraphNumber);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public void CreateParagraphAndNote(List<SubLegalArea> selection, int ParagraphNumber, string headLine, string Lawtext) // laver paragraf, sætter op i SubLegalAreaParagraph tabellen, laver note, forbinder dem
        {

            if (selection.Count == 0) // stopper hvis der ikke er valgt underområde
            {
                throw new System.Exception("Der skal være valgt et underområde");
            }

            int PK_P;
            DbManager.CreateParagraph(ParagraphNumber, headLine, Lawtext); //laver paragraf i databasen
            PK_P = DbManager.GetRecentParagraph(); //henter den seneste paragraph primary key og assigner den til variable

            for (int i = 0; i < selection.Count; i++) //forbvinder noten med alle valgte underområder i mange til mange tabellen i databasen - SubAreaParagrph tabellen
            {
                DbManager.InsertSubLegalAreaParagraph(PK_P, selection[i].Id);
            }
            DbManager.CreateNote(PK_P); //laver en note hvor foreign key er paragraffens primary key
        }
    }
}

