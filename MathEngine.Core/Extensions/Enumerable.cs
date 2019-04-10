using System;
using System.Collections.Generic;
using System.Text;

namespace MathEngine.Core.Extensions
{
    public static class Enumerable
    {
        public static IEnumerable<double> Range(double start, double end)
        {
            for (var current = start; current <= end; ++current)
            {
                yield return current;
            }
        }

        public static IEnumerable<long> Range(long start, long end)
        {
            for (var current = start; current <= end; ++current)
            {
                yield return current;
            }
        }
    }
}
