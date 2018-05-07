using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;
using System.Web.Profile;

namespace Magicnote.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        
        
        private List<SubLegalArea> _subLegalAreas;
        public DbManager DbManager;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Note> Note { get; set; }
        public List<MainLegalArea> MainLegalAreas { get; }
        public List<SubLegalArea> SubLegalAreas { get; set; }
        public List<Paragraph> Paragraphs { get; set; }


        public MainViewModel()
        {
            DbManager = new DbManager();
            MainLegalAreas = DbManager.GetMainLegalAreas();
            
        }
        public void GetSubLegalArea(int number)
        {
            SubLegalAreas = DbManager.GetSubAreas(number);
            OnPropertyChanged("SubLegalAreas");
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
