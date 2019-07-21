using Formulas.Core.Calcs.Trigonometry;
using Formulas.Core.Entities.Numbers;
using Formulas.Core.Resolutions;
using Formulas.Core.Utils.Extensions;
using System;
using System.Collections.Generic;

namespace Formulas.Core.Steps.Trigonometry
{
    public class PythagorasResolution
    {
        private readonly string BaseFormula;
        private readonly PythagorasCalculation _calculation;        

        public PythagorasResolution(PythagorasCalculation calculation)
        {
            BaseFormula = "a² = b² + c²";
            _calculation = calculation;
        }

        public List<Resolution> Generate()
        {
            List<string> steps = new List<string>
            {
                BaseFormula
            };

            if (_calculation.Incognite == "A")
            {                
                string step1 = $"a² = ({_calculation.Formula.Variables.B})² + ({_calculation.Formula.Variables.C})²";
                steps.Add(step1);

                double bSquared = _calculation.BSquared();
                double cSquared = _calculation.CSquared();

                string step2 = $"a² = {bSquared} + {cSquared}";
                steps.Add(step2);

                double sum = bSquared + cSquared;

                string step3 = $"a² = {sum}";
                steps.Add(step3);

                string step4 = $"a = √{sum}";
                steps.Add(step4);

                double calculatedRoot = Math.Round(Math.Sqrt(sum), 2);

                if (!calculatedRoot.IsInteger() && sum.IsInteger())
                {
                    NumberRoot simplifiedRoot = Convert.ToInt32(sum).SimplifiedRoot();
                    steps.Add($"a = {simplifiedRoot.DisplayValue}");
                }
                else
                {
                    steps.Add($"a = {calculatedRoot}");
                }
            }
            else if (_calculation.Incognite == "B")
            {
                steps.Add($"{_calculation.Formula.Variables.A}² = b² + {_calculation.Formula.Variables.C}²");

                double aSquared = _calculation.ASquared();
                double cSquared = _calculation.CSquared();

                steps.Add($"{aSquared} = b² + {cSquared}");

                steps.Add($"b² = {aSquared} - {cSquared}");

                double subtraction = aSquared - cSquared;

                steps.Add($"b² = {subtraction}");

                steps.Add($"b = √{subtraction}");

                if (subtraction.IsInteger())
                {
                    NumberRoot simplifiedRoot = Convert.ToInt32(subtraction).SimplifiedRoot();
                    steps.Add($"b = {simplifiedRoot.DisplayValue}");
                }
                else
                {
                    steps.Add( $"b = {Math.Round(Math.Sqrt(subtraction), 2)}" );
                }
            }
            else
            {
                steps.Add($"{_calculation.Formula.Variables.A}² = {_calculation.Formula.Variables.B} + c²");

                double aSquared = _calculation.ASquared();
                double bSquared = _calculation.BSquared();

                steps.Add($"{aSquared} = {bSquared} + c²");

                steps.Add($"c² = {aSquared} - {bSquared}");

                double subtraction = aSquared - bSquared;

                steps.Add($"c² = {subtraction}");

                steps.Add($"c = √{subtraction}");

                if (subtraction.IsInteger())
                {
                    NumberRoot simplifiedRoot = Convert.ToInt32(subtraction).SimplifiedRoot();
                    steps.Add($"c = {simplifiedRoot.DisplayValue}");
                }
                else
                {
                    steps.Add($"c = {Math.Round(Math.Sqrt(subtraction), 2)}");
                }                
            }

            var resolutions = new List<Resolution>();
            resolutions.Add(new Resolution
            {
                Name = "Normal",
                Steps = steps
            });

            return resolutions;
        }
    }
}
