using Formulas.Core.Calcs.Algebra;
using System;
using System.Collections.Generic;

namespace Formulas.Core.Resolutions.Algebra
{
    public class BhaskaraResolution : IFormulaResolution
    {        
        public string BaseFormula { get; }

        private readonly BhaskaraCalculation _calculation;

        public BhaskaraResolution(BhaskaraCalculation calculation)
        {
            BaseFormula = "( b² +- √(b² - 4.a.c) )/2.a";
            _calculation = calculation;       
        }

        public List<Resolution> Generate()
        {
            List<string> steps = new List<string>();
            steps.Add(BaseFormula);

            double a = _calculation.Formula.Variables.A;
            double b = _calculation.Formula.Variables.B;
            double c = _calculation.Formula.Variables.C;

            string step1 =
                $"( b² +- √({b}² - 4.{a}.{c}) ) / 2.A";
            steps.Add(step1);

            double delta = _calculation.GetDeltaValue();

            string step2 = $"( b² +- √({delta}) ) / 2.A";
            steps.Add(step2);

            string step3 = $"( {b}² +- √({delta}) ) / 2.{a}";
            steps.Add(step3);

            double deltaRoot = Math.Round(Math.Sqrt(delta), 2);
            double bSquared = b * b;
            double twoA = a * 2;

            string step4 = $"( {bSquared} +- {deltaRoot} ) / {twoA}";
            steps.Add(step4);

            var resolutions = new List<Resolution>
            {
                new Resolution
                {
                    Name = "Solving Delta",
                    Steps = steps
                }
            };


            List<string> stepsX1 = new List<string>();

            string stepsX1_1 = $"x' = ( {bSquared} + {deltaRoot} ) / {twoA}";
            stepsX1.Add(stepsX1_1);

            double bPlusDeltaRoot = bSquared + deltaRoot;

            string stepsX1_2 = $"x' = ( {bPlusDeltaRoot} ) / {twoA}";
            stepsX1.Add(stepsX1_2);

            double resultX1 = (bSquared + deltaRoot) / twoA;

            string stepsX1_3 = $"x' = {Math.Round(resultX1, 2)}";
            stepsX1.Add(stepsX1_3);

            resolutions.Add(new Resolution
            {
                Name = "X' (X1)",
                Steps = stepsX1
            });

            List<string> stepsX2 = new List<string>();

            string stepsX2_1 = $"x' = ( {bSquared} + {deltaRoot} ) / {twoA}";
            stepsX1.Add(stepsX2_1);

            double bMinusDeltaRoot = bSquared - deltaRoot;

            string stepsX2_2 = $"x' = ( {bMinusDeltaRoot} ) / {twoA}";
            stepsX1.Add(stepsX2_2);

            double resultX2 = (bSquared + deltaRoot) / twoA;

            string stepsX2_3 = $"x' = {Math.Round(resultX1, 2)}";
            stepsX1.Add(stepsX2_3);

            resolutions.Add(new Resolution
            {
                Name = "X'' (X2)",
                Steps = stepsX2
            });

            return resolutions;
        }
    }
}
