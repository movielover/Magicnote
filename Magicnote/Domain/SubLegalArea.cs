﻿using System.Collections.Generic;

namespace Magicnote.Domain
{
    public class SubLegalArea
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Paragraf> Paragrafs { get; set; }
    }
}
