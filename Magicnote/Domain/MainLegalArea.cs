using System.Collections.Generic;

namespace Magicnote.Domain
{
    public class MainLegalArea
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<SubLegalArea> SubLegalAreas { get; set; }


        public void NavigationList()
        {

        }
    }
}
