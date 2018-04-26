using System.Collections.Generic;

namespace Magicnote
{
    public interface IArea
    {
        List<string> SelectionList(string t);

        void Select(string t);

    }
}
