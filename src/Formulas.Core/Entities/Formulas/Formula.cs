using Formulas.Core.Exceptions;
using Formulas.Core.Validations;
using Formulas.Core.Variables;

namespace Formulas.Core.Entities.Formulas
{
    public abstract class Formula
    {
        public FormulaValidation Validation { get; set; }        
        protected Result Result { get; set; }

        public virtual Result Execute()
        {
            try
            {
                Validation.Validate();
                return Resolve();
            }
            catch(InvalidInputException ex)
            {
                return GetErrorResult(ex.Message.ToString());
            }
        }   
        
        protected abstract Result Resolve();

        protected virtual Result GetErrorResult(string error)
        {
            return new Result { Message = error };
        }
    }
}
