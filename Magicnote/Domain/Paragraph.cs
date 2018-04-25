using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicnote.Domain
{
    public class Paragraph
    {
        public int ParagraphNumber { get; set; }

        public string Headline { get; set; }

        public string Lawtext { get; set; }

        public void UpdateParagraf()
        {

        }

        public string ParagraphNode()
        {
            return ParagraphNumber.ToString() + " " + Headline;
        }

        public List<string> ParagraphList(string SubArea)
        {
            List<string> ParagraphList = new List<string>();
            foreach (object Paragraph in SubArea)
            {
                ParagraphList.Add(ParagraphNode());
            }
            return ParagraphList;
        }

    }
}
