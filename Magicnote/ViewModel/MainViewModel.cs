using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;

namespace Magicnote.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;
        public SubLegalArea SubLegalArea;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<Note> Notes { get; set; }
        public List<MainLegalArea> MainLegalAreas { get; }
        public List<SubLegalArea> SubLegalAreas { get; set; }
        public List<Paragraph> Paragraphs { get; set; }


        public MainViewModel()
        {
            DbManager = new DbManager();
            SubLegalArea = new SubLegalArea();
            MainLegalAreas = DbManager.GetMainLegalAreas();
            //SubLegalAreas = DbManager.GetSubAreas(1);

        }
        public void GetSubLegalArea(int number)
        {
            DbManager.GetSubAreas(number);
            SubLegalAreas = SubLegalArea.SubLegalAreas;
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
