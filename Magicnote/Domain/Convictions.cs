using System;

namespace Magicnote.Domain
{
    public class Convictions
    {
        public DateTime DateTime { get; set; }

        public string Author { get; set; }

        public string SummaryForConviction { get; set; }

        public string UrlToExternalPdf { get; set; }
    }
}
