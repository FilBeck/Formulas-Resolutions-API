using Formulas.Core.Entities;
using Formulas.Core.Entities.Formulas.Algebra;
using Formulas.Core.Variables.Algebra;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.FormulaTests
{
    [TestClass]
    public class AlgebraTest
    {
        [TestMethod]
        public void BhaskaraTest()
        {
            BhaskaraVariables variables = new BhaskaraVariables
            {
                A = 1,
                B = 4,
                C = -5
            };

            Bhaskara bhaskara = new Bhaskara(variables);
            Result result = bhaskara.Execute();

            Assert.IsTrue(result != null);
        }
    }
}
