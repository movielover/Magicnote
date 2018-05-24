using Magicnote.Domain;
using System.ComponentModel;

namespace ViewModel
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;
        private Paragraph _paragraph;

        public event PropertyChangedEventHandler PropertyChanged;

        private string _noteText { get; set; }
        public string NoteText
        {
            get => _noteText;

            set
            {
                _noteText = value;
                OnPropertyChanged(NoteText);
            }
        }

        private string _headline { get; set; }
        public string Headline
        {
            get => _headline;

            set
            {
                _headline = value;
                OnPropertyChanged(Headline);
            }
        }
        private string _lawtext { get; set; }
        public string LawText
        {
            get => _lawtext;

            set
            {
                _lawtext = value;
                OnPropertyChanged(LawText);
            }
        }

        private int _paragraphNumber { get; set; }
        public int ParagraphNumber
        {
            get => _paragraphNumber;

            set
            {
                _paragraphNumber = value;
                OnPropertyChanged(ParagraphNumber.ToString());
            }
        }

        public NoteViewModel()
        {
            DbManager = new DbManager();
        }

  

        public void GetParagraphsToNote(int pkPId)
        {
            _paragraph =DbManager.GetParagraphsToNote(pkPId);
            Headline = _paragraph.Headline;
            LawText = _paragraph.LawText;
            ParagraphNumber = _paragraph.ParagraphNumber;
             
        }

        public void SaveNoteToDb(string noteText, int paragraphNumber)
        {
            DbManager.SaveNote(noteText, paragraphNumber);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}

