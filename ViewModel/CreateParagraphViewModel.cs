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
        public DbManager DbManager;

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

        public void GetSubLegalArea(int subAreaId)
        {
            SubLegalAreas = DbManager.GetSubAreas(subAreaId).ToList();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}