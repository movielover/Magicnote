using System.Collections.Generic;

namespace Magicnote.Domain
{
    public class SubLegalArea
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<SubLegalArea> SubLegalAreas = new List<SubLegalArea>();
    }
}
