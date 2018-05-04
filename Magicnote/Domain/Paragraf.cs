using System.Collections.Generic;

namespace Magicnote.Domain
{
    public class Paragraph
    {
        public int Number { get; set; }

        public string Headline { get; set; }

        public string Lawtext { get; set; }


        public string MenuNode()
        {
            return Number.ToString() + " " + Headline;
        }
        
        public List<string> AllParagrafs()
        {
            List<string> ListOfParagrafs = new List<string>();

            foreach(object Paragraf in SubLegalArea)
            {
                ListOfParagrafs.Add(MenuNode());
            }
            return ListOfParagrafs;
        }
    }    
}
