using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathEngine.Core.Calculators
{
    public class PrimeNumbersCalculator : ISequenceCalculator
    {
        public string Name => "primenumbers";

        public IEnumerable<double> Calculate(double upperLimit)
        {
            var values = new List<double>();

            if (upperLimit >= 1)
                yield return 1.0;

            var currentValue = 2.0;

            while (values.Count() < upperLimit-1)
            {
                if (!values.Any(i => currentValue % i == 0))
                {
                    values.Add(currentValue);
                    yield return currentValue;
                }
                currentValue++;
            }
        }
    }
}
