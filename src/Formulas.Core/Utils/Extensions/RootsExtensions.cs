using Formulas.Core.Entities.Numbers;
using System.Collections.Generic;
using System.Linq;

namespace Formulas.Core.Utils.Extensions
{
    public static class RootsExtensions
    {
        public static NumberRoot SimplifiedRoot(this int num, int rootIndex = 2)
        {
            List<int> primeFactors = num.Decompose().ToList();

            var groupedFactors = from factor in primeFactors
                                 group factor by factor into g
                                 let count = g.Count()
                                 orderby count descending
                                 select new
                                 {
                                     Factor = g.Key,
                                     Count = count
                                 };

            List<int> coefficients = new List<int>();
            List<int> radicatings = new List<int>();

            foreach (var factor in groupedFactors)
            {
                int factorCount = (int) factor.Count / rootIndex;
                for (var i = 0; i < factorCount; i++)
                {
                    coefficients.Add(factor.Factor);
                }

                int factorRest = factor.Count % rootIndex;
                for (var i = 0; i < factorRest; i++)
                {
                    radicatings.Add(factor.Factor);
                }
                
            }

            int coefficientValue = 1;
            int radicatingValue = 1;

            foreach (var value in coefficients) coefficientValue = coefficientValue * value;
            foreach (var value in radicatings) radicatingValue = radicatingValue * value;

            NumberRoot numberRoot = new NumberRoot(coefficientValue, radicatingValue);

            return numberRoot;
        }
    }
}
