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

            dbManager.GetMainLegalAreas();

            List<MainLegalArea> mainLegalAreas = dbManager.GetMainLegalAreas();

            Console.WriteLine(
                $"Capacity: {mainLegalAreas.Capacity}\n" +
                $"Count: {mainLegalAreas.Count}\n"
                );
        }
    }
}
