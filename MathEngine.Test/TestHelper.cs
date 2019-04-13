using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MathEngine.Test
{
    public static class TestHelper
    {
        public static async Task<T> ExecuteTestWithTimeout<T>(Func<T> testFunc, int timeout, string timeoutErrorMessage)
        {
            var act = Task.Run(testFunc);

            var timeoutTask = Task.Run(() => Task.Delay(timeout));

            var res = await Task.WhenAny(timeoutTask, act);

            if (res == timeoutTask)
                Assert.True(false, timeoutErrorMessage);

            return act.Result;
        }
    }
}
