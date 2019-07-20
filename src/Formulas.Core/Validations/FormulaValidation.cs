using Formulas.Core.Entities.Formulas;

namespace Formulas.Core.Validations
{
    public abstract class FormulaValidation
    {
        protected Formula _formula { get; set; }        
        public string Message { get; set; }

        public FormulaValidation(Formula formula)
        {
            _formula = formula;
        }

        public abstract void Validate();
    }
}
