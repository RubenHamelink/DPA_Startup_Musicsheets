using System.Collections.Generic;

namespace DPA_MusicSheets_Service.Concrete.Interpreter
{
    public class Context
    {
        private Dictionary<string, int> _variables;

        public Context()
        {
            _variables = new Dictionary<string, int>();
        }

        public int this[string variableName]
        {
            get { return _variables[variableName]; }
            set { _variables[variableName] = value; }
        }
    }
}
