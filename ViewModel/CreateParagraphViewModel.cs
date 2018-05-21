using Magicnote.Annotations;
using Magicnote.Domain;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ViewModel
{
    public class CreateParagraphViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DbManager DbManager;

        public List<MainLegalArea> MainLegalAreas { get; }

        private List<SubLegalArea> _subLegalAreas;

        public List<SubLegalArea> SubLegalAreas
        {
            get => _subLegalAreas;

            set
            {
                _subLegalAreas = value;
                OnPropertyChanged("SubLegalAreas");
            }
        }

        public CreateParagraphViewModel()
        {
            DbManager = new DbManager();
            SubLegalAreas = new List<SubLegalArea>();
            MainLegalAreas = DbManager.GetMainLegalAreas();
            _subLegalAreas = new List<SubLegalArea>();
        }

        public void GetSubLegalArea(int subAreaId)
        {
            SubLegalAreas = DbManager.GetSubAreas(subAreaId).ToList();
        }

        public void CreateParagraphAndNote(int paragraphNumber, string headLine, string lawtext, int id)
        {
            DbManager.CreateParagraph(paragraphNumber, headLine, lawtext, id);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}