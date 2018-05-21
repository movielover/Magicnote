using Magicnote.Domain;
using System.ComponentModel;

namespace ViewModel
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        public static DbManager DbManager;
        public SubLegalArea SubLegalArea;
        public Paragraph Paragraph;
        public event PropertyChangedEventHandler PropertyChanged;

        private string _headLine;
        private string _lawtext;
        private int _paragraphnumber;
        private string _notetext;

        public string Headline
        {
            get => _headLine;

            set
            {
                _headLine = value;
                OnPropertyChanged(nameof(Headline));
            }
        }
        public string LawText
        {
            get => _lawtext;

            set
            {
                _lawtext = value;
                OnPropertyChanged(nameof(LawText));
            }
        }
        public string NoteText
        {
            get => _notetext;

            set
            {
                _notetext = value;
                OnPropertyChanged(nameof(NoteText));
            }
        }
        public int ParagraphNumber
        {
            get => _paragraphnumber;

            set
            {
                _paragraphnumber = value;
                OnPropertyChanged(nameof(ParagraphNumber));
            }
        }


        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public static void SaveNoteToDb(string textRangeText, int paragraphNumber)
        {
            string noteText = "";
            DbManager.SaveNote(noteText, paragraphNumber);
        }
        public void GetNote(int paragraphNumber)
        {
            NoteText = DbManager.GetNote(paragraphNumber);
        }

        public void GetPForView()
        {
            ParagraphNumber = DbManager.GetRecentParagraph();
            NoteText = DbManager.GetNote(ParagraphNumber);
        }

    }

}

