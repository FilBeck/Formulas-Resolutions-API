using System;
using System.Collections.Generic;
using System.Text;

namespace Formulas.Core.Calcs.Algebra
{
    public class Algebra
    {
        /// <summary>
        /// b² - 4ac
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static double Delta(double a, double b, double c)
        {
            return b * b - (4 * a * c);
        }
    }
}
