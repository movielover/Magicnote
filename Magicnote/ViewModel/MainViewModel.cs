using Magicnote.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.POCO;
using Magicnote.Annotations;


namespace Magicnote.ViewModel
{
    public class MainViewModel
    {
        public static DbManager DbManager;
        
        public List<MainLegalArea> MainLegalAreas { get; set; }
        static List<SubLegalArea> SubLegalAreas { get; set; }
        
        

        public MainViewModel()
        {
            DbManager = new DbManager();
            MainLegalAreas = DbManager.GetMainLegalAreas();
        }
        public static void GetSubLegalArea(int number)
        {
            SubLegalAreas = DbManager.GetSubAreas(number);
            
        }

        public static void GetParagraph(int paragraphId)
        {
            throw new NotImplementedException();
        }

       

        
    }
}
