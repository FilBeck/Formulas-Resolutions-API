using System.Collections.Generic;

namespace Formulas.Core.Resolutions
{
    public abstract class Resolution
    {               
        public string BaseFormulaString { get; set; }   
        public List<string> Steps { get; set; }

        public abstract void Generate();
    }
}
