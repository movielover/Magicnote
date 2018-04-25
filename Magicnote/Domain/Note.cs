﻿using System;

namespace Magicnote.Domain
{
    public class Note
    {
        public string Text { get; set; }

        public string ReferenceToParagraf { get; set; }

        public DateTime DateTime { get; set; }

        public string Author { get; set; }

    }
}
