using System.Collections.Generic;
using DPA_Musicsheets.Domain.Entity;

namespace DPA_MusicSheets_Service.Abstract
{
    public interface ILilypondInterpreter
    {
        IEnumerable<MusicalSymbol> LoadSymbols(IEnumerable<string> lilyPond);
    }
}