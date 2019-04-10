using MathEngine.Core.Calculators;
using System;
using System.Collections.Generic;
using Xunit;
using MathEngineClass = MathEngine.Core.MathEngine;
using Ext = MathEngine.Core.Extensions;
using System.Linq;

namespace MathEngine.Test
{
    public class ExtensionsTest
    {
        #region [ Range ]

        public static IEnumerable<object[]> RangeDoubleDataTest =>
            new List<object[]>
            {
                new object[] {0,0, new [] { 0.0} },
                new object[] {0,1, new [] { 0.0,1.0} },
                 new object[] {0,2, new [] { 0.0,1.0,2.0} },
            };


        [Theory]
        [MemberData(nameof(RangeDoubleDataTest))]
        public void Range_Double_RangeDataTest(double start, double end, IEnumerable<double> expected)
        {
            var actual = Ext.Enumerable.Range(start, end).ToList();

            Assert.Equal(expected, actual);
        }


        #endregion [ Range ]
    }
}
