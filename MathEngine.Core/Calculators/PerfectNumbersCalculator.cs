using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathEngine.Core.Calculators
{
    public class PerfectNumbersCalculator : ISequenceCalculator
    {
        public string Name => "perfectnumbers";

        public IEnumerable<double> Calculate(double upperLimit)
        {
            var counter = 0;
            var index = 1;
            while (counter < upperLimit - 1)
            {
                double sum = 0;
                for (int j = 0; j < index; j++)
                {
                    if (index % j == 0)
                    {
                        sum += j;
                    }
                }
                if (sum == index)
                {
                    yield return index;
                    counter++;
                }
                index++;
            }
        }
    }
}
