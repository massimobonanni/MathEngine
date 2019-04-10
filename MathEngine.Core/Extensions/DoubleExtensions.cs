using System;
using System.Collections.Generic;
using System.Text;

namespace MathEngine.Core.Extensions
{
    public static class DoubleExtensions
    {
        public static IEnumerable<double> GetDividers(this double number)
        {
            for (double i = 0; i < number / 2 + 1; i++)
            {
                if (number % i == 0)
                    yield return i;
            }
        }
    }
}
