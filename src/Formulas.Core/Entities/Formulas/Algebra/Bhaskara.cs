using Formulas.Core.Variables.Algebra;

namespace Formulas.Core.Entities.Formulas.Algebra
{
    public class Bhaskara : Formula
    {
        public BhaskaraVariables Variables { get; set; }
        //public BhaskaraResolution Steps { get; set; }

        public Bhaskara(BhaskaraVariables variables)
        {
            Variables = variables;
        }

        protected override Result Resolve()
        {
            throw new System.NotImplementedException();
        }
    }
}
