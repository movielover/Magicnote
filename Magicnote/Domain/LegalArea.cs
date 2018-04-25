using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicnote.Domain
{
    class LegalArea: IArea
    {

        //List<SubLegalArea> subAreas = new List<SubLegalArea>();
        List<string> subAreas = new List<string>();
        

        public List<string> SelectionList(string Main)
        {
            for (int i = 0; i < 10; i++)
            {
                subAreas.Add("list" + i);
            }

            // DBHandler.GetSubAreas(Main);
            // foreach area in DBsubarea
            //{
            //subAreas.Add(DBM subarea)
            //}
            //return List<SubLegalArea>;
            return subAreas;
        }

        public void select(string Main)
        {
            SubLegalArea.SelectionList();
        }
    }
}
