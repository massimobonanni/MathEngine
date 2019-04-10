using MathEngine.Core.Calculators;
using System;

namespace MathEngine.Core
{
    public static class MathEngine
    {
        public static ISequenceCalculator CreateSequenceCalculator(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));
            
            switch (name.ToLower())
            {
                case "fibonacci":
                    return new FibonacciCalculator();
                case "primes":
                    return new PrimeNumbersCalculator();
                default:
                    return null;
            }

        }
    }
}
