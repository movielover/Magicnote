using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicnote.Domain
{
    public class SubLegalArea : IArea
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Paragraph> Paragraphs { get; set; }

        List<Paragraph> subAreas = new List<Paragraph>();
        List<string> _paragra = new List<string>();

        SubLegalArea Sub = new SubLegalArea();

        private List<string> ParagraphNames = new List<string>();
        


        public List<string> SelectionList(string Main)
        {
            
            
            foreach (object SubLegalArea in Sub)
            {
                ParagraphNames.Add(Sub.Name);
            }

            return ParagraphNames;
        }
        public void Select(String paragraf)
        {
            Paragraph P = new Paragraph();

            P.ParagraphList(paragraf);
            
        }

        
    }
}
