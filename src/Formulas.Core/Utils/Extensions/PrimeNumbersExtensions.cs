using Formulas.Core.Helpers;
using System.Collections.Generic;

namespace Formulas.Core.Utils.Extensions
{
    public static class PrimeNumbersExtensions
    {
        /// <summary>
        /// Retrieves the prime factors of the decomposed integer
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>       
        public static int[] Decompose(this int num)
        {
            int[] primeNumbers = PrimeNumbersHelper.GetPrimeNumbersRange(0, num);

            List<int> primeFactors = new List<int>();

            int currentNumber = num;
            for (int i = 0; i < primeNumbers.Length; i++)
            {
                if (currentNumber % primeNumbers[i] == 0)
                {
                    currentNumber = currentNumber / primeNumbers[i];
                    primeFactors.Add(primeNumbers[i]);
                    i = -1;
                }

                if (currentNumber == 1) break;
            }

            return primeFactors.ToArray();
        }

        public static bool IsPrime(this int number)
        {
            // Test whether the parameter is a prime number.
            if ((number & 1) == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Not the square root version
            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }

            return number != 1;
        }
    }
}
