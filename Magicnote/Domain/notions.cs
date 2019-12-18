using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicnote.Domain
{
    public class Notions
    {
        //Denne klasse skal definere de begreber der skal bruges på tværs af paragraffer.
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}
