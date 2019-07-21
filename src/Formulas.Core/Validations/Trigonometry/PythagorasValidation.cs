using Formulas.Core.Entities.Formulas;
using Formulas.Core.Entities.Formulas.Trigonometry;
using Formulas.Core.Exceptions;
using System;

namespace Formulas.Core.Validations.Trigonometry
{
    public class PythagorasValidation : FormulaValidation
    {
        public PythagorasValidation(Formula formula) : base(formula, null)
        {
            Validate();
        }

        public override void Validate()
        {
            if (_formula.GetType() == typeof(Pythagoras))
            {
                var variables = ((Pythagoras)_formula).Variables;

                if (variables.A == null && variables.B == null)
                    throw new InvalidInputException("A e B nulos");
                else if (variables.A == null && variables.C == null)
                    throw new InvalidInputException("A e C nulos");
                else if (variables.B == null && variables.C == null)
                    throw new InvalidInputException("B e C nulos");
            }
        }

        public void Validate(int e)
        {           
        }
    }
}
