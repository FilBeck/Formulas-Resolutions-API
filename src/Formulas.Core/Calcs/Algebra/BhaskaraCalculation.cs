using Formulas.Core.Entities;
using Formulas.Core.Entities.Formulas.Algebra;
using Formulas.Core.Exceptions;
using Formulas.Core.Variables.Algebra;

namespace Formulas.Core.Calcs.Algebra
{
    public class BhaskaraCalculation : Calculation<BhaskaraVariables>
    {
        private double _a;
        private double _b;
        private double _c;

        public Bhaskara Formula { get; set; }

        public BhaskaraCalculation(Bhaskara formula)
        {
            Formula = formula;

            HandleIncognites(Formula.Variables);

            Result = new Result();
        }

        public override void Calculate()
        {
            throw new System.NotImplementedException();
        }

        public override void HandleIncognites(BhaskaraVariables variables)
        {
            if (variables.A == null &&
                variables.B == null &&
                variables.C == null)
                throw new InvalidInputException();
        }

        /// <summary>
        /// b² - 4ac
        /// </summary>
        /// <returns></returns>
        public double GetDeltaValue()
        {            
            double delta = (Formula.Variables.B * Formula.Variables.B) - 4 * Formula.Variables.A * Formula.Variables.C;
            return delta;
        }       
    }
}
