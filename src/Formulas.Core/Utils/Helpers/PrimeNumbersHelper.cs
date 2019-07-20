using Formulas.Core.Utils.Extensions;
using System.Collections.Generic;

namespace Formulas.Core.Helpers
{
    public static class PrimeNumbersHelper
    {
        public static int[] GetPrimeNumbers()
        {
            return new int[]
            {
#region Prime numbers list
                2,
                3,
                5,
                7,
                11,
                13,
                17,
                19,
                23,
                29,
                31,
                37,
                41,
                43,
                47,
                53,
                59,
                61,
                71,
                73,
                79,
                83,
                89,
                97,
                101
#endregion
            };
        }

        public static int[] GetPrimeNumbersRange(int start, int final)
        {
            List<int> primeNumbers = new List<int>();

            for (int i = start; i < final; i++)
            {
                if (i.IsPrime()) primeNumbers.Add(i);
            }

            return primeNumbers.ToArray();
        }
    }
}
