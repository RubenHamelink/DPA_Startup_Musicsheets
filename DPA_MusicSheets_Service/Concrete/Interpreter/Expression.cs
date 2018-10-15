using System.Collections.Generic;
using DPA_Musicsheets.Domain.Entity;

namespace DPA_MusicSheets_Service.Concrete.Interpreter
{
    public abstract class Expression
    {
        public abstract IEnumerable<MusicalSymbol> Interpret(Context context);
    }
}
