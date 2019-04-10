using CommandLine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathEngine.Console.Options
{
    [Verb("perfectnumbers", HelpText = "Calculate the perfect numbers sequence")]
    internal class PerfectNumbersOptions : SequenceOptions
    {
        public override string CalculatorName => "perfectnumbers";
    }
}
