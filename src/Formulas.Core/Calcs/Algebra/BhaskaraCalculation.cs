using Formulas.Core.Entities;
using Formulas.Core.Entities.Formulas.Algebra;
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
            throw new System.NotImplementedException();
        }
    }
}
