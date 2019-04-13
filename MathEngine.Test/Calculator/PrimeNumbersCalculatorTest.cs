using MathEngine.Core.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MathEngine.Test.Calculator
{
    public class PrimeNumbersCalculatorTest
    {
        public static IEnumerable<object[]> PrimeNumbersSequences =>
            new List<object[]>
            {
                new object[] {1,new double[] { 1} },
                new object[] {2,new double[] { 1,2} },
                new object[] {3,new double[] { 1,2,3} },
                new object[] {4,new double[] { 1,2,3,5} },
                new object[] {5,new double[] { 1,2,3,5,7} },
                new object[] {6,new double[] { 1,2,3,5,7,11} },
                new object[] {7,new double[] { 1,2,3,5,7,11,13} },
                new object[] {8,new double[] { 1,2,3,5,7,11,13,17} },
                new object[] {9,new double[] { 1,2,3,5,7,11,13,17,19} },
                new object[] {10,new double[] { 1,2,3,5,7,11,13,17,19,23} },
            };

        [Theory]
        [MemberData(nameof(PrimeNumbersSequences))]
        public async Task Calculate_ArgumentRight(long upperLimit, double[] expectedSequence)
        {
            var target = new PrimeNumbersCalculator();

            var actual = await TestHelper.ExecuteTestWithTimeout<IEnumerable<double>>(
               () => target.Calculate(upperLimit).ToList(),
               5000,
               "Test failed because timeout elapsed");

            Assert.Equal(expectedSequence.Count(), actual.Count());
            for (int i = 0; i < expectedSequence.Count(); i++)
            {
                Assert.Equal(expectedSequence[i], actual.ElementAt(i));
            }
        }
    }
}
