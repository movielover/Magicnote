﻿using Magicnote.Domain;
using System;
using System.Collections.Generic;

namespace Magicnote.ViewModel
{
    public class MainViewModel
    {
        public DbManager DbManager;


        public List<MainLegalArea> MainLegalAreas { get; }
        public List<SubLegalArea> SubLegalAreas { get; set; }

        public MainViewModel()
        {
            DbManager = new DbManager();
            MainLegalAreas = DbManager.GetMainLegalAreas();
        }

        public void GetSubLegalArea(int number)
        {
            List<SubLegalArea> localList = DbManager.GetSubAreas(number);
            SubLegalAreas = localList;
        }

        public void GetParagraph(int paragraphId)
        {
            throw new NotImplementedException();
        }
    }
}
