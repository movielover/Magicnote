﻿using System;
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

        MainLegalArea Main = new MainLegalArea();
       
        public List<string> AreaNames = new List<string>();


        public List<string> SelectionList(string Main)
        {
            foreach (object MainLegalArea in Main)
            {
                AreaNames.Add(Name);
            }

           
            return AreaNames;
        }
        public void Select(String SubAreas)
        {

        }
    }
}
