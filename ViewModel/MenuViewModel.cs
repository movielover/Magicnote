using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;

namespace ViewModel
{
    public class MenuViewModel : INotifyPropertyChanged
    {
        public DbManager DbManager;

        public MenuViewModel()
        {
            DbManager = new DbManager();
            MainLegalAreas = DbManager.GetMainLegalAreas();
            _subLegalAreas = new List<SubLegalArea>();
            _paragraphs = new List<Paragraph>();
        }
        public event PropertyChangedEventHandler PropertyChanged;

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

        private List<Paragraph> _paragraphs;

        public List<Paragraph> Paragraphs
        {
            get => _paragraphs;

            set
            {
                _paragraphs = value;
                OnPropertyChanged(nameof(Paragraphs));
            }
        }

        public void GetSubLegalArea(int mainAreaId)
        {
            SubLegalAreas = DbManager.GetSubAreas(mainAreaId);
        }

        public void GetParagraphs(int subAreaId)
        {
            Paragraphs = DbManager.GetParagraphs(subAreaId);
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
