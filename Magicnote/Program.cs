using Magicnote.Domain;
using Magicnote.ViewModel;
using System;

namespace Magicnote
{
    internal class Program
    {
        static Paragraph para = new Paragraph();
        static MainViewModel MVM = new MainViewModel();
        private static void Main()
        {
            MVM.GetParagraphs(1);
            string text = MVM.Paragraphs[0].Lawtext;

            Console.WriteLine(text);
            Console.ReadLine();

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

