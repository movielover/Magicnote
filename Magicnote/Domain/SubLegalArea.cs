using System;
using System.Collections.Generic;

namespace Magicnote.Domain
{
    public class SubLegalArea : IArea
    {
        public string Title { get; set; }

        public Paragraph Paragraph { get; set; }

        public List<Paragraph> Paragraphs { get; set; }


        public List<string> SelectionList(string main)
        {
            throw new Exception();
        }

        public void Select(string paragraf)
        {
            Paragraph p = new Paragraph();

            p.ParagraphList(paragraf);

        }
    }
}
