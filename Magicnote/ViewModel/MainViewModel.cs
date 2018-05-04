using Magicnote.Domain;
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
            //tallet skal rettes så det symbolisere den aktuelle værdi af valget brugeren tager.
            SubLegalAreas = DbManager.GetSubAreas(1);

        }

    }
}
