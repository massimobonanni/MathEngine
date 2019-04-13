using MathEngine.Core.Calculators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MathEngine.Test.Calculator
{
    public class PerfectNumbersCalculatorTest
    {
        public static IEnumerable<object[]> PerfectNumbersSequences =>
            new List<object[]>
            {
                new object[] {1,new double[] { 6} },
                new object[] {2,new double[] { 6,28} },
                new object[] {3,new double[] { 6,28,496} },
                new object[] {4,new double[] { 6,28,496,8128} },
                 new object[] {5,new double[] { 6,28,496,8128, 33550336 } },
            };

        [Theory]
        [MemberData(nameof(PerfectNumbersSequences))]
        public async Task Calculate_ArgumentRight(long upperLimit, double[] expectedSequence)
        {
            var target = new PerfectNumbersCalculator();

            var actual = await TestHelper.ExecuteTestWithTimeout<IEnumerable<double>>(
                () => target.Calculate(upperLimit).ToList(),
                10000,
                "Test failed because timeout elapsed");

            Assert.Equal(expectedSequence.Count(), actual.Count());
            for (var i = 0; i < expectedSequence.Count(); i++)
            {
                Assert.Equal(expectedSequence[i], actual.ElementAt(i));
            }
        }

       
    }
}
