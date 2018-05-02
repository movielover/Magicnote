using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Magicnote.Domain
{
    //skal ændres
    public class SubLegalArea : IArea, IEnumerable
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Paragraph> Paragraphs { get; set; }
        public string Title { get; set; }

        //List<Paragraf> subAreas = new List<Paragraf>();
        List<string> Paragraf = new List<string>();

        SubLegalArea Sub = new SubLegalArea();

        List<string> ParagraphNames = new List<string>();



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

        //skal ændres
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
