﻿using System;
using System.Collections.Generic;

namespace Magicnote.Domain
{
    public class MainLegalArea
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<MainLegalArea> MainLegalAreas { get; set; }

        public List<SubLegalArea> SubLegalAreas { get; set; }

        public List<string> SelectionList(string main)
        {
            throw new Exception();
        }
        public void Select(string paragraf)
        {

        }
    }
}
