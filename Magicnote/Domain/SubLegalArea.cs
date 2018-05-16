using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Magicnote.Annotations;

namespace Magicnote.Domain
{
    public class SubLegalArea : INotifyPropertyChanged
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;

    }
    
}
