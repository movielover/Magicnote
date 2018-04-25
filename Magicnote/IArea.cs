using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicnote
{
    interface IArea
    {
        List<string> SelectionList(string t);

        void Select(string t);
        
    }
}
