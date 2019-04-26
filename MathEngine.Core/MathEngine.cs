using MathEngine.Core.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MathEngine.Core
{
    public static class MathEngine
    {
        private static IEnumerable<ISequenceCalculator> sequenceCalculators =
            new List<ISequenceCalculator>() { new FibonacciCalculator(),
                new PrimeNumbersCalculator() }; // , new PerfectNumbersCalculator() };

        public static ISequenceCalculator CreateSequenceCalculator(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            var calculator = sequenceCalculators.FirstOrDefault(c => c.Name.ToLower() == name.ToLower());

            if (calculator != null)
                return calculator;
            else
                return null;

        }
    }
}
