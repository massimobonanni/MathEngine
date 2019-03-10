using MathEngine.Core.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace MathEngine.Test.Calculator
{
    public class FibonacciCalculatorTest
    {
        public static IEnumerable<object[]> FibonacciSequences =>
            new List<object[]>
            {
                new object[] {0,new long[] { 0} },
                new object[] {1,new long[] { 0,1} },
                new object[] {2,new long[] { 0,1,1} },
                new object[] {3,new long[] { 0,1,1,2} },
                new object[] {4,new long[] { 0,1,1,2,3} },
                new object[] {5,new long[] { 0,1,1,2,3,5} },
            };

        [Theory]
        [MemberData(nameof(FibonacciSequences))]
        public void Calculate_ArgumentRight(long upperLimit, long[] expectedSequence)
        {
            var target = new FibonacciCalculator();

            var actual = target.Calculate(upperLimit);

            Assert.Equal(expectedSequence.Count(), actual.Count());
            for (int i = 0; i < expectedSequence.Count(); i++)
            {
                Assert.Equal(expectedSequence[i], actual.ElementAt(i));
            }
        }
    }
}
