using System;
using System.ComponentModel;

namespace Magicnote.Domain
{
    public class SubLegalArea : INotifyPropertyChanged
    {
        public int ID;

        public string Title;

        public event PropertyChangedEventHandler PropertyChanged;


        public SubLegalArea()
        {

        }

        public SubLegalArea(int value)
        {
            this.ID = value;
        }
        public SubLegalArea(string value)
        {
            this.Title = value;
        }
        
        public int SubLegalAreaID
        {
            get { return ID; }
            set { ID = value;
                OnPropertyChanged(nameof(SubLegalArea));
                    }
        }

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        //public int Id { get; set; }

        //public string Title { get; set; }


    }
}
