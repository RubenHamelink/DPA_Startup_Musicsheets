﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPA_Musicsheets.Domain.Entity
{
    public class Barline : MusicalSymbol
    {
        public IEnumerable<MusicalSymbol> MusicalSymbols { get; set; }
    }
}
