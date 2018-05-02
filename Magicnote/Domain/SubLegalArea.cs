using System;
using System.Collections.Generic;

namespace Magicnote.Domain
{
    public class SubLegalArea : IArea
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Paragraph> Paragraphs { get; set; }

        List<Paragraph> subAreas = new List<Paragraph>();
        List<string> _paragra = new List<string>();

        SubLegalArea subLegalArea = new SubLegalArea();

        private List<string> ParagraphNames = new List<string>();


        public List<string> SelectionList(string main)
        {
            throw new Exception();
        }

        //public List<string> SelectionList(string Main)
        //{


        //    foreach (object SubLegalArea in subLegalArea)
        //    {
        //        ParagraphNames.Add(subLegalArea.Title);
        //    }

        //    return ParagraphNames;
        //}
        public void Select(String paragraf)
        {
            Paragraph P = new Paragraph();

            P.ParagraphList(paragraf);

        }


    }
}
