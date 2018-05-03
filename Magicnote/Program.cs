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

            dbManager.SetMainAreas();

            List<MainLegalArea> mainLegalAreas = dbManager.MainLegalArea.MainLegalAreas;

            Console.WriteLine(mainLegalAreas);
        }
    }
}
