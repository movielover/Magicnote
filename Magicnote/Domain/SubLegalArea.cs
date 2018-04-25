using System;
using System.Collections.Generic;

namespace Magicnote.Domain
{
    public class SubLegalArea : IArea
    {
        private readonly List<string> _paragraf = new List<string>();


        public List<string> SelectionList(string main)
        {
            for (int i = 0; i < 10; i++)
            {
                _paragraf.Add("list" + i);
            }

            // DBHandler.GetSubAreas(Main);
            // foreach area in DBsubarea
            //{
            //subAreas.Add(DBM subarea)
            //}
            //return List<SubLegalArea>;
            return _paragraf;
        }

        public void Select()
        {
            throw new NotImplementedException();
        }

        public void Select(String paragraf)
        {
            Paragraph P = new Paragraph();

            P.ParagraphList(paragraf);
            
        }

        List<IArea> IArea.SelectionList(string t)
        {
            throw new NotImplementedException();
        }
    }
}
