using Magicnote.Domain;
using Magicnote.ViewModel;

namespace Magicnote
{
    internal class Program
    {
        static Paragraph para = new Paragraph();
        static MainViewModel MVM = new MainViewModel();
        private static void Main()
        {
            //MVM.GetParagraphs(2);
            //string text = MVM.Paragraphs[0].Lawtext;

            //Console.WriteLine(text);
            //Console.WriteLine();
            //foreach (Paragraph mvmParagraph in MVM.Paragraphs)
            //{
            //    Console.WriteLine(mvmParagraph.Headline);
            //    Console.WriteLine(mvmParagraph.Lawtext);
            //}
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
