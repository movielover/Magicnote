using System.Collections.Generic;
using System.ComponentModel;
using Magicnote.Domain;

namespace ViewModel
{
    public class ParagraphViewModel : INotifyPropertyChanged
    {
        public SubLegalArea SubLegalArea;
        public Paragraph Paragraph;

        public event PropertyChangedEventHandler PropertyChanged;

        public List<MainLegalArea> MainLegalAreas { get; }

        private List<SubLegalArea> _subLegalAreas;

        public ParagraphViewModel(List<MainLegalArea> mainLegalAreas)
        {
            MainLegalAreas = mainLegalAreas;
        }


        public List<SubLegalArea> SubLegalAreas
        {
            get => _subLegalAreas;

            set
            {
                _subLegalAreas = value;
                OnPropertyChanged(nameof(SubLegalAreas));
            }
        }

        private List<Paragraph> _paragraphs { get; set; }

        public List<Paragraph> Paragraphs
        {
            get => _paragraphs;

            set
            {
                _paragraphs = value;
                OnPropertyChanged(nameof(Paragraphs));
            }
        }
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
