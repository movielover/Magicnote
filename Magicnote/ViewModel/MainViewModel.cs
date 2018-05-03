using Magicnote.Domain;
using System.Collections.Generic;

namespace Magicnote.ViewModel
{
    public class MainViewModel
    {
        public DbManager DbManager;

        public List<MainLegalArea> MainLegalAreas { get; set; }

        public MainViewModel()
        {
            DbManager = new DbManager();
            MainLegalAreas = DbManager.GetMainLegalAreas();

        }
    }
}
