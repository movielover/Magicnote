using System.Collections.Generic;
using Magicnote.Domain;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace ViewModel
{
    public class NoteViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;
        
        public event PropertyChangedEventHandler PropertyChanged;

        public NoteViewModel()
        {
            DbManager = new DbManager();
        }

        private string _headline { get; set; }
        public string Headline
        {
            get => _headline;

            set
            {
                _headline = value;
                OnPropertyChanged((Headline));
            }
        }
        private string _lawtext { get; set; }
        public string LawText
        {
            get => _lawtext;

            set
            {
                _lawtext = value;
                OnPropertyChanged((LawText));
            }
        }
        private string _paragraphNumber { get; set; }
        public string ParagraphNumber
        {
            get => _paragraphNumber;

            set
            {
                _paragraphNumber = value;
                OnPropertyChanged((ParagraphNumber));
            }
        }




        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
         public void GetParagraph(int pkPId)
        {
            DbManager.GetParagraph(pkPId);
        }


        public void SaveNoteToDb(string noteText, int paragraphNumber)
        {
            DbManager.SaveNote(noteText, paragraphNumber);
        }
    }

}

