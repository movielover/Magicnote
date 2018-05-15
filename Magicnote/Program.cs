using Magicnote.Domain;
using System;
using System.Collections.Generic;
using Magicnote.ViewModel;

namespace Magicnote
{
    internal class Program
    {
        static Paragraph para = new Paragraph();
        static MainViewModel MVM = new MainViewModel();
        static DbManager DBM = new DbManager();
        static public List<MainLegalArea> MainLegalAreas { get; set; }
        private static void Main()
        {

            //string text = "hej";

            //MainLegalAreas = DBM.GetMainLegalAreas();

            //foreach (object MainLegalArea in MainLegalAreas)
            //{
            //    Console.WriteLine(MainLegalArea.ToString());
            //}
            //Console.ReadLine();



            //MVM.GetParagraphs(1);
            //text = MVM.Paragraphs[0].Lawtext;

            //Console.WriteLine(text);
            //Console.ReadLine();

            

        }

        
        

        //private static void Run()
        //{
        //    MainViewModel mainViewModel = new MainViewModel();
        //    mainViewModel.GetSubLegalArea(4);
        //    foreach (var SubLegalArea in mainViewModel.SubLegalAreas)
        //    {
        //        Console.WriteLine(SubLegalArea.Title); 
        //    }
            
    }
}

