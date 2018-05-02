using System.Collections.Generic;

namespace Magicnote.Domain
{
    public class MainLegalArea
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<MainLegalArea> MainLegalAreas = new List<MainLegalArea>();

        public List<SubLegalArea> SubLegalAreas { get; set; }

        public List<MainLegalArea> GetMainLegalAreas()
        {
            return MainLegalAreas;
        }
    }
}
