using System;

namespace Formulas.Core.Utils.Extensions
{
    public static class NumberExtensions
    {
        public static bool IsInteger(this double num)
        {
            return num == Math.Round(num, 0);
        }
    }
}
