using System.Collections.Generic;

namespace MathEngine.Core.Calculators
{
    internal class FibonacciCalculator : ISequenceCalculator
    {
        public string Name => "fibonacci";

        public IEnumerable<double> Calculate(double upperLimit)
        {
            var values = new double[] { 0, 1, 1 };

            if (upperLimit >= 0)
                yield return values[0];
            if (upperLimit >= 1)
                yield return values[1];
            if (upperLimit >= 2)
                yield return values[2];

            for (long index = 3; index <= upperLimit; ++index)
            {
                values[0] = values[1];
                values[1] = values[2];
                values[2] = values[0] + values[1];
                yield return values[2];
            }

        }
    }
}
