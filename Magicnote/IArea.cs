using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicnote
{
    interface IArea
    {
        List<IArea> SelectionList(string t);

        void select();
        
    }
}
