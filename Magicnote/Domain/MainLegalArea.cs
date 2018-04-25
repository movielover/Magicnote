using System;
using System.Collections.Generic;

namespace Magicnote.Domain
{
    public class MainLegalArea
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<SubLegalArea> SubLegalAreas { get; set; }


        public void NavigationList()
        {

        }

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

        }
    }
}
