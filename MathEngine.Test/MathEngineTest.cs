using MathEngine.Core.Calculators;
using System;
using System.Collections.Generic;
using Xunit;
using MathEngineClass = MathEngine.Core.MathEngine;

namespace MathEngine.Test
{
    public class MathEngineTest
    {
        #region [ CreateSequenceCalculator ]
        [Fact]
        public void CreateSequenceCalculator_NameNull_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => MathEngineClass.CreateSequenceCalculator(null));
        }

        [Fact]
        public void CreateSequenceCalculator_NameEmpty_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => MathEngineClass.CreateSequenceCalculator(string.Empty));
        }

        [Fact]
        public void CreateSequenceCalculator_NameWhitespace_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => MathEngineClass.CreateSequenceCalculator("   "));
        }

        public static IEnumerable<object[]> CalculatorNames =>
            new List<object[]>
            {
                new object[] {"fibonacci",typeof(FibonacciCalculator)},
                new object[] {"primes",typeof(PrimeNumbersCalculator)},
                new object[] {"unknown",null},
            };

        [Theory]
        [MemberData(nameof(CalculatorNames))]
        public void CreateSequenceCalculator_CalculatorNameNotNull(string sequencename, Type componentTypeExpected)
        {
            var actual = MathEngineClass.CreateSequenceCalculator(sequencename);

            if (componentTypeExpected == null)
                Assert.Null(actual);
            else
                Assert.IsType(componentTypeExpected, actual);
        }
        #endregion [ CreateSequenceCalculator ]
    }
}
