using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathEngine.Console.Options
{
    [Verb("primenumbers", HelpText = "Calculate the prime numbers sequence")]
    internal class PrimeNumbersOptions : SequenceOptions
    {
        public override string CalculatorName => "primenumbers";
    }
}
