using System.Collections.Generic;

namespace Magicnote
{
    internal interface IArea
    {
        List<IArea> SelectionList(string t);

        void Select();

    }
}
