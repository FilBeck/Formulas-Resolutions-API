using Formulas.Core.Calcs.Trigonometry;
using Formulas.Core.Steps.Trigonometry;
using Formulas.Core.Validations.Trigonometry;
using Formulas.Core.Variables.Trigonometry;
using System;

namespace Formulas.Core.Entities.Formulas.Trigonometry
{
    public class Pythagoras : Formula
    {
        public double? A { get; set; }
        public double? B { get; set; }
        public double? C { get; set; }

        public PythagorasVariables Variables { get; set; }
        public PythagorasResolution Steps { get; set; }

        public Pythagoras(PythagorasVariables variables)
        {
            Variables = variables;                      
        }

        public override Result Execute()
        {
            try
            {
                Validation = new PythagorasValidation(this);
                return Resolve();
            }
            catch (Exception ex)
            {
                return GetErrorResult(ex.Message.ToString());
            }
        }

        protected override Result Resolve()
        {
            var calculation = new PythagorasCalculation(this);
            calculation.Calculate();
            Steps = new PythagorasResolution(calculation);
            calculation.GenerateSteps(Steps);
            return calculation.Result;
        }
    }
}
