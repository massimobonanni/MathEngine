using MathEngine.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ext = MathEngine.Core.Extensions;

namespace MathEngine.Core.Calculators
{
    public class PerfectNumbersCalculator : ISequenceCalculator
    {
        public string Name => "perfectnumbers";

        private static IDictionary<int, double> Numbers = new Dictionary<int, double>() {
            {1,6.0},
            {2,28.0},
            {3,496-0},
            {4,8128.0},
            {5,33550336.0},
            {6,8589869056.0},
            {7,137438691328.0},
            {8,2305843008139952128.0},
        };
        public IEnumerable<double> Calculate(double upperLimit)
        {
            for (var i = 0; i < upperLimit; i++)
            {
                yield return Numbers[i + 1];
            }

        }

        //public IEnumerable<double> Calculate(double upperLimit)
        //{
        //    if (upperLimit >= 1)
        //        yield return 6.0;

        //    var innerCalculator = new PrimeNumbersCalculator();

        //    var counter = 2;
        //    while (counter <= upperLimit)
        //    {
        //        var prime = innerCalculator.Calculate(counter + 1).Last();
        //        var perfect = Math.Pow(2, prime - 1) * (Math.Pow(2, prime) - 1);
        //        var sumDividers = perfect.GetDividers().Aggregate((a, b) => a + b);
        //        if (sumDividers == perfect)
        //        {
        //            yield return perfect;
        //            counter++;
        //        }
        //    }
        //}
    }
}
