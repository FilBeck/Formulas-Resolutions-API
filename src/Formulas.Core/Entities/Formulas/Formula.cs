using Formulas.Core.Validations;

namespace Formulas.Core.Entities.Formulas
{
    public abstract class Formula
    {
        public FormulaValidation Validation { get; set; }
        protected Result Result { get; set; }

        public abstract Result Execute();        
        protected abstract Result Resolve();

        protected virtual Result GetErrorResult(string error)
        {
            return new Result { Message = error };
        }
    }
}
