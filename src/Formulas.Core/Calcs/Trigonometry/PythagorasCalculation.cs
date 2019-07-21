using Formulas.Core.Entities;
using Formulas.Core.Entities.Formulas.Trigonometry;
using Formulas.Core.Entities.Numbers;
using Formulas.Core.Utils.Extensions;
using Formulas.Core.Variables.Trigonometry;
using System;
using System.Collections.Generic;

namespace Formulas.Core.Calcs.Trigonometry
{
    public class PythagorasCalculation : Calculation<PythagorasVariables>
    {
        private double _a;
        private double _b;
        private double _c;

        public Pythagoras Formula { get; set; }

        public PythagorasCalculation(Pythagoras formula)
        {
            Formula = formula;

            HandleIncognites(Formula.Variables);

            Result = new Result();
        }

        public override void Calculate()
        {
            List<string> results = new List<string>();
            
            if (Incognite == "A")
            {
                double bPlusC = Math.Round((_b * _b) + (_c * _c), 2);
                double numericResult = Math.Sqrt(bPlusC);
                results.Add(numericResult.ToString());

                // chama a raiz, se o resultado for inteiro
                if (!numericResult.IsInteger() && bPlusC.IsInteger())
                { 
                    NumberRoot rootRes = Convert.ToInt32(bPlusC).SimplifiedRoot();
                    results.Add(rootRes.DisplayValue);
                }
            }
            else if (Incognite == "B")
            {
                double aMinusC = Math.Round((_a * _a) - (_c * _c), 2);
                double numericResult = Math.Sqrt(aMinusC);
                results.Add(numericResult.ToString());

                if (!numericResult.IsInteger() && aMinusC.IsInteger())
                {
                    NumberRoot rootRes = Convert.ToInt32(aMinusC).SimplifiedRoot();
                    results.Add(rootRes.DisplayValue);
                }
            }
            else
            {
                double aMinusB = Math.Round((_a * _a) - (_b * _b), 2);
                double numericResult = Math.Sqrt(aMinusB);
                results.Add(numericResult.ToString());
                
                if (!numericResult.IsInteger() && aMinusB.IsInteger())
                {
                    NumberRoot rootRes = Convert.ToInt32(aMinusB).SimplifiedRoot();
                    results.Add(rootRes.DisplayValue);
                }
            }

            Result.Answers.AddRange(results);
        }

        public double ASquared()
        {
            return (_a * _a);
        }

        public double BSquared()
        {
            return (_b * _b);
        }

        public double CSquared()
        {
            return (_c * _c);
        }

        public override void HandleIncognites(PythagorasVariables variables)
        {
            _a = variables.A ?? 0;
            _b = variables.B ?? 0;
            _c = variables.C ?? 0;

            Incognite = variables.FindIncognite();
        }
    }
}
