﻿using Magicnote.Domain;
using System.Collections.Generic;

namespace Magicnote.ViewModel
{
    public class MainViewModel
    {
        public string Title { get; set; }

        public DbManager DbManager;

        public List<MainLegalArea> MainLegalAreas { get; }

        public MainViewModel()
        {
            DbManager = new DbManager();
            MainLegalAreas = DbManager.GetMainLegalAreas();
        }

    }
}
