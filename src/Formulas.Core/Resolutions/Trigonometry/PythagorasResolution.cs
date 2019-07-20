using Formulas.Core.Calcs.Trigonometry;
using Formulas.Core.Entities.Numbers;
using Formulas.Core.Resolutions;
using Formulas.Core.Utils.Extensions;
using System;
using System.Collections.Generic;

namespace Formulas.Core.Steps.Trigonometry
{
    public class PythagorasResolution: Resolution
    {
        private readonly PythagorasCalculation _calculation;

        public PythagorasResolution(PythagorasCalculation calculation)
        {
            BaseFormulaString = "a² = b² + c²";
            _calculation = calculation;

            Steps = new List<string>();
        }

        public override void Generate()
        {
            Steps.Add(BaseFormulaString);

            if (_calculation.Incognite == "A")
            {                
                string step1 = $"a² = ({_calculation.Formula.Variables.B})² + ({_calculation.Formula.Variables.C})²";
                Steps.Add(step1);

                double bSquared = _calculation.BSquared();
                double cSquared = _calculation.CSquared();

                string step2 = $"a² = {bSquared} + {cSquared}";
                Steps.Add(step2);

                double sum = bSquared + cSquared;

                string step3 = $"a² = {sum}";
                Steps.Add(step3);

                string step4 = $"a = √{sum}";
                Steps.Add(step4);

                double calculatedRoot = Math.Round(Math.Sqrt(sum), 2);

                if (!calculatedRoot.IsInteger() && sum.IsInteger())
                {
                    NumberRoot simplifiedRoot = Convert.ToInt32(sum).SimplifiedRoot();
                    Steps.Add($"a = {simplifiedRoot.DisplayValue}");
                }
                else
                {
                    Steps.Add($"a = {calculatedRoot}");
                }
            }
            else if (_calculation.Incognite == "B")
            {
                Steps.Add($"{_calculation.Formula.Variables.A}² = b² + {_calculation.Formula.Variables.C}²");

                double aSquared = _calculation.ASquared();
                double cSquared = _calculation.CSquared();

                Steps.Add($"{aSquared} = b² + {cSquared}");                

                Steps.Add($"b² = {aSquared} - {cSquared}");

                double subtraction = aSquared - cSquared;

                Steps.Add($"b² = {subtraction}");

                Steps.Add($"b = √{subtraction}");

                if (subtraction.IsInteger())
                {
                    NumberRoot simplifiedRoot = Convert.ToInt32(subtraction).SimplifiedRoot();
                    Steps.Add($"b = {simplifiedRoot.DisplayValue}");
                }
                else
                {
                    Steps.Add( $"b = {Math.Round(Math.Sqrt(subtraction), 2)}" );
                }
            }
            else
            {
                Steps.Add($"{_calculation.Formula.Variables.A}² = {_calculation.Formula.Variables.B} + c²");

                double aSquared = _calculation.ASquared();
                double bSquared = _calculation.BSquared();

                Steps.Add($"{aSquared} = {bSquared} + c²");

                Steps.Add($"c² = {aSquared} - {bSquared}");

                double subtraction = aSquared - bSquared;

                Steps.Add($"c² = {subtraction}");

                Steps.Add($"c = √{subtraction}");

                if (subtraction.IsInteger())
                {
                    NumberRoot simplifiedRoot = Convert.ToInt32(subtraction).SimplifiedRoot();
                    Steps.Add($"c = {simplifiedRoot.DisplayValue}");
                }
                else
                {
                    Steps.Add($"c = {Math.Round(Math.Sqrt(subtraction), 2)}");
                }
            }
        }
    }
}
