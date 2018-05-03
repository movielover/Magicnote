using Magicnote.Domain;
using System;
using System.Collections.Generic;

namespace Magicnote
{
    internal class Program
    {
        private static void Main()
        {
            Run();
        }

        private static void Run()
        {
            DbManager dbManager = new DbManager();

            List<MainLegalArea> mainLegalAreas = dbManager.GetMainLegalAreas();

            foreach (MainLegalArea mainLegalArea in mainLegalAreas)
            {
                Console.WriteLine(mainLegalArea.Title);
            }
        }
    }
}
