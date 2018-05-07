using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;

namespace Magicnote.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private List<SubLegalArea> _subLegalAreas;
        public DbManager DbManager;

        public event PropertyChangedEventHandler PropertyChanged;

        public <List<Note> 
        public List<MainLegalArea> MainLegalAreas { get; }
        public List<SubLegalArea> SubLegalAreas {
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
            //SubLegalAreas = DbManager.GetSubAreas(number); 
            SubLegalAreas = new List<SubLegalArea>()
            {
                new SubLegalArea()
            };
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
