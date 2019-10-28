using Formulas.Core.Calcs.Trigonometry;
using Formulas.Core.Resolutions;
using Formulas.Core.Steps.Trigonometry;
using Formulas.Core.Validations;
using Formulas.Core.Variables.Trigonometry;
using System.Collections.Generic;

namespace Formulas.Core.Entities.Formulas.Trigonometry
{
    public class Pythagoras : Formula
    {                
        public PythagorasVariables Variables { get; set; }

        public Pythagoras(PythagorasVariables variables)
        {
            Variables = variables;
            Validation = new FormulaValidation(this, Variables);
        }

        protected override Result Resolve()
        {
            var calculation = new PythagorasCalculation(this);
            calculation.Calculate();
            PythagorasResolution resolution = new PythagorasResolution(calculation);
            List<Resolution> steps = resolution.Generate();
            calculation.Result.Resolutions.AddRange(steps);
            return calculation.Result;
        }
    }
}
