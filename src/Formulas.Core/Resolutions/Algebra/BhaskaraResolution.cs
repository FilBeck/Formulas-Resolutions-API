using Formulas.Core.Calcs.Algebra;
using System.Collections.Generic;

namespace Formulas.Core.Resolutions.Algebra
{
    public class BhaskaraResolution : IFormulaResolution
    {        
        public string BaseFormula { get; }

        private readonly BhaskaraCalculation _calculation;

        public BhaskaraResolution(BhaskaraCalculation calculation)
        {
            BaseFormula = "( b² +- √(b² - 4.a.c) )/2.a";
            _calculation = calculation;       
        }

        public List<Resolution> Generate()
        {
            throw new System.NotImplementedException();
        }
    }
}
