using CommandLine;
using MathEngine.Console.Options;
using MathEngine.Core;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathEngine.Console
{

    class Program
    {
        private static Type[] options = new[] { typeof(FibonacciOptions) };


        static int Main(string[] args)
        {
            var result = Parser.Default.ParseArguments(args, options)
            .MapResult(o => ExecuteCommand(o), errs => 1);

            if (Debugger.IsAttached)
                System.Console.ReadLine();
            return result;
        }

        private static int ExecuteCommand(object o)
        {
            if (o is SequenceOptions)
                return ExecuteSequenceCommand(o as SequenceOptions);
            //if (o is ScalarOptions)
            //    return ExecuteScalarCommand(o);
            return 1;
        }

        private static int ExecuteSequenceCommand(SequenceOptions o)
        {
            ISequenceCalculator calculator = MathEngine.Core.MathEngine.CreateSequenceCalculator(o.CalculatorName);

            if (calculator != null)
            {
                var result = calculator.Calculate(o.MaxValue);
                foreach (var value in result)
                {
                    System.Console.Write($"{value}, ");
                }
                System.Console.WriteLine();
                return 0;
            }
            return 1;
        }
    }
}
