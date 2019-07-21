using Formulas.Core.Entities.Formulas;
using Formulas.Core.Exceptions;
using Formulas.Core.Variables;
using System.Collections.Generic;
using System.Reflection;

namespace Formulas.Core.Validations
{
    public class FormulaValidation
    {
        public string Message { get; set; }

        protected Formula _formula { get; set; }
        protected FormulaVariables _variables { get; set; }

        public FormulaValidation(Formula formula, FormulaVariables variables)
        {
            _formula = formula;
            _variables = variables;
        }

        public virtual void Validate()
        {
            ValidateVariables();
        }

        private void ValidateVariables()
        {
            PropertyInfo[] formulaVariables = _variables.GetVariables();
            
            int nullCounter = 0;
                      
            List<string> nullNames = new List<string>();

            foreach (var variable in formulaVariables)
            {
                var value = variable.GetValue(_variables, null);
                if (value == null)
                {
                    nullCounter++;
                    nullNames.Add(variable.Name);
                }
            }

            if (nullCounter == 0) throw new InvalidInputException("At least one variable must be null");
            if (nullCounter >= 2) throw new InvalidInputException(nullNames.ToArray(), "There are more than one variable with a null value");
        }
    }
}
