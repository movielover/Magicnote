using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;

namespace Magicnote.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public List<Paragraph> Paragraphs;
        private List<SubLegalArea> _subLegalAreas;
        public DbManager DbManager;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Note> Note { get; set; }
        public List<MainLegalArea> MainLegalAreas { get; }
        public List<SubLegalArea> SubLegalAreas
        {
            get
            {
                return _subLegalAreas;
            }
            set
            {
                _subLegalAreas = value;
                OnPropertyChanged("SubLegalAreas");
            }
        }

        public MainViewModel()
        {
            DbManager = new DbManager();
            MainLegalAreas = DbManager.GetMainLegalAreas();
        }
        public void GetSubLegalArea(int number)
        {
            SubLegalAreas = DbManager.GetSubAreas(number);
        }
        
        public void GetParagraphs(int i)
        {
            Paragraphs = DbManager.GetParagraphs(i);
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
