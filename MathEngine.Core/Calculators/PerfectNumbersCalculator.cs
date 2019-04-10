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

        //public IEnumerable<double> Calculate(double upperLimit)
        //{
        //    if (upperLimit >= 1)
        //        yield return 6.0;

        //    var counter = 1;
        //    var value = 7.0;
        //    while (counter < upperLimit)
        //    {

        //        var dividers = Ext.Enumerable.Range(1.0, value - 1)
        //            .Where(d => value % d == 0);

        //        if (dividers.Any())
        //        { 
        //           var sum=dividers.Aggregate((a, b) => a + b);
        //            if (sum == value)
        //            {
        //                yield return value;
        //                counter++;
        //            }
        //        }
        //        value++;
        //    }           
        //}

        public IEnumerable<double> Calculate(double upperLimit)
        {
            if (upperLimit >= 1)
                yield return 6.0;

            var innerCalculator = new PrimeNumbersCalculator();

            var counter = 2;
            while (counter <= upperLimit)
            {
                var prime = innerCalculator.Calculate(counter + 1).Last();
                var perfect = Math.Pow(2, prime - 1) * (Math.Pow(2, prime) - 1);
                var sumDividers = perfect.GetDividers().Aggregate((a, b) => a + b);
                if (sumDividers == perfect)
                {
                    yield return perfect;
                    counter++;
                }
            }

        }
    }
}
