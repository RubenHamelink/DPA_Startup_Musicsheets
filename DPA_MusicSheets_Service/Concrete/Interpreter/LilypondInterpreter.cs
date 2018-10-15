using System.Collections.Generic;
using DPA_Musicsheets.Domain.Entity;
using DPA_MusicSheets_Service.Abstract;

namespace DPA_MusicSheets_Service.Concrete
{
    public class LilypondInterpreter : ILilypondInterpreter
    {
        private IList<string> reservedWords = new List<string>
        {
            "\\relative", "\\clef", "treble", "\\time", "\\tempo", "\\repeat", "volta", "\\alternative"
        };

        public IEnumerable<MusicalSymbol> LoadSymbols(IEnumerable<string> lilyPond)
        {

        }
    }
}