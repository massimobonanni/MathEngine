using CommandLine;

namespace MathEngine.Console.Options
{
    internal abstract class SequenceOptions
    {
        [Option("maxValue", Required = true, HelpText = "Maximum value used to calculate the sequence.")]
        public int MaxValue { get; set; }

        abstract public string CalculatorName { get; }
    }
}