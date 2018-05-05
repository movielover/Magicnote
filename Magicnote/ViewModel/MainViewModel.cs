using Magicnote.Domain;
using System;
using System.Collections.Generic;

namespace Magicnote.ViewModel
{
    public class MainViewModel
    {
        public DbManager DbManager;

        public List<MainLegalArea> MainLegalAreas { get; }
        public List<SubLegalArea> SubLegalAreas { get; }

        public MainViewModel()
        {
            DbManager = new DbManager();
            MainLegalAreas = DbManager.GetMainLegalAreas();
            SubLegalAreas = DbManager.SubLegal;
        }

        public void GetSubLegalArea(int number)
        {
            DbManager.GetSubAreas(number);
            //SubLegalAreas = DbManager.subLegal;
        }

        public void GetParagraph(int paragraphId)
        {
            throw new NotImplementedException();
        }
    }
}
