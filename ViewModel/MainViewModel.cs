using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;

namespace ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;

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
            MainLegalAreas = DbManager.GetMainLegalAreas();
            _subLegalAreas = new List<SubLegalArea>();
            _paragraphs = new List<Paragraph>();

           

        }

        public void GetSubLegalArea(int number)
        {
            SubLegalAreas = DbManager.GetSubAreas(number);
        }

        public void GetParagraphs(int paragraphNumber)
        {
            Paragraphs = DbManager.GetParagraphs(paragraphNumber);
        }

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

        public void CreateParagraphAndNote(int paragraphNumber, string headLine, string lawtext, int id)
        {
            DbManager.CreateParagraph(paragraphNumber, headLine, lawtext, id);
        }
    }
}



