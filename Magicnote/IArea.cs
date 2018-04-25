using System.Collections.Generic;

namespace Magicnote
{
    internal interface IArea
    {
        List<string> SelectionList(string t);

        void Select(string t);
        
    }
}
