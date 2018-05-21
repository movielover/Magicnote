using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;
        public SubLegalArea SubLegalArea;
        public Paragraph Paragraph;

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


        public MainViewModel()
        {
            DbManager = new DbManager();
            SubLegalArea = new SubLegalArea();
            MainLegalAreas = DbManager.GetMainLegalAreas();
            Paragraph = new Paragraph();
            _subLegalAreas = new List<SubLegalArea>();
            _paragraphs = new List<Paragraph>();

            //GetParagraphs(1);
            GetNote(1);

        }

        public void GetSubLegalArea(int number)
        {
            SubLegalAreas = DbManager.GetSubAreas(number);

        }

        public void GetParagraphs(int paragraphNumber)
        {
            Paragraphs = DbManager.GetParagraphs(paragraphNumber);
        }


        //public void AddNote(string noteText, int paragraphId)
        //{
        //    DbManager.CreateNote(noteText, paragraphId);
        //}

       



        

       

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CreateParagraphAndNote(int paragraphNumber, string headLine, string lawtext, int id) // laver paragraf, sætter op i SubLegalAreaParagraph tabellen, laver note, forbinder dem
        {
            //int PK_P;
            DbManager.CreateParagraph(paragraphNumber, headLine, lawtext, id); //laver paragraf i databasen
            //PK_P = DbManager.GetRecentParagraph(); //henter den seneste paragraph primary key og assigner den til variable

            //DbManager.CreateNote(PK_P); //laver en note hvor foreign key er paragraffens primary key

            //public void CreateParagraphAndNote(List<SubLegalArea> selection, int paragraphNumber, string headLine,
            //    string lawtext) // laver paragraf, sætter op i SubLegalAreaParagraph tabellen, laver note, forbinder dem
            //{

            //    if (selection.Count == 0) // stopper hvis der ikke er valgt underområde
            //    {
            //        throw new System.Exception("Der skal være valgt et underområde");
            //    }

            //    int PK_P;
            //    DbManager.CreateParagraph(paragraphNumber, headLine, lawtext); //laver paragraf i databasen
            //    PK_P = DbManager
            //        .GetRecentParagraph(); //henter den seneste paragraph primary key og assigner den til variable

            //    for (int i = 0;
            //        i < selection.Count;
            //        i++) //forbvinder noten med alle valgte underområder i mange til mange tabellen i databasen - SubAreaParagrph tabellen
            //    {
            //        DbManager.InsertSubLegalAreaParagraph(PK_P, selection[i].ID);
            //    }

            //    DbManager.CreateNote(PK_P); //laver en note hvor foreign key er paragraffens primary key
        }
    }
}



