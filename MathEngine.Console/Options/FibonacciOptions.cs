using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathEngine.Console.Options
{
    [Verb("fibonacci", HelpText = "Calculate the Fibonacci sequence")]
    internal class FibonacciOptions : SequenceOptions
    {
        public override string CalculatorName => "fibonacci";
    }
}
