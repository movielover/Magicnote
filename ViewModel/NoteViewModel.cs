using Magicnote.Domain;
using System.ComponentModel;

namespace ViewModel
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;
        private Paragraph _paragraph;

        public event PropertyChangedEventHandler PropertyChanged;

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

        private string _paragraphNumber { get; set; }
        public string ParagraphNumber
        {
            get => _paragraphNumber;

            set
            {
                _paragraphNumber = value;
                OnPropertyChanged(ParagraphNumber);
            }
        }

        public NoteViewModel(Paragraph paragraph)
        {
            _paragraph = paragraph;
            DbManager = new DbManager();
        }

        public void GetParagraph(int pkPId)
        {
            _paragraph = DbManager.GetParagraph(pkPId);
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

