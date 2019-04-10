using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MathEngine.Core
{
    public interface IScalarCalculator: ICalculator
    {
        double Calculate(double arg);
    }
}
