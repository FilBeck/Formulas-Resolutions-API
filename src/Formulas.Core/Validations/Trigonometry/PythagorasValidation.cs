using Formulas.Core.Entities.Formulas;
using Formulas.Core.Entities.Formulas.Trigonometry;
using System;

namespace Formulas.Core.Validations.Trigonometry
{
    public class PythagorasValidation : FormulaValidation
    {
        public PythagorasValidation(Formula formula) : base(formula)
        {
            Validate();
        }

        public override void Validate()
        {
            if (_formula.GetType() == typeof(Pythagoras))
            {
                var variables = ((Pythagoras)_formula).Variables;

                if (variables.A == null && variables.B == null)
                    throw new Exception("A e B nulos");
                else if (variables.A == null && variables.C == null)
                    throw new Exception("A e C nulos");
                else if (variables.B == null && variables.C == null)
                    throw new Exception("B e C nulos");
            }
        }
    }
}
