using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAdvanced.AdvancedCalculator.Interface
{
    public interface ICalculatorAdvanced
    {
        public double squar(double value1, int value2);
        public double root(double value1, double value2);
        public double cos(double value1, double value2);
        public double sin(double value1, double value2);
        public double tan(double value1, double value2);
    }
}
