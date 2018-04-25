using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicnote.Domain
{
    public class SubLegalArea : IArea
    {
        //List<Paragraf> subAreas = new List<Paragraf>();
        List<string> Paragraf = new List<string>();


        public List<string> SelectionList(string Main)
        {
            for (int i = 0; i < 10; i++)
            {
                Paragraf.Add("list" + i);
            }

            // DBHandler.GetSubAreas(Main);
            // foreach area in DBsubarea
            //{
            //subAreas.Add(DBM subarea)
            //}
            //return List<SubLegalArea>;
            return Paragraf;
        }
        public void Select(String paragraf)
        {
            Paragraph P = new Paragraph();

            P.ParagraphList(paragraf);
            
        }
    }
}
