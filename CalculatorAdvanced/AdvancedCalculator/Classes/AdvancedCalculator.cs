using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorAdvanced.AdvancedCalculator.Classes
{
    public class AdvancedCalculator
    {
        public double Pow(double value1, int value2)
        {
            double result;
            int i;
            result = 1.0;
            for (i = 1, i <= value2; i++) ;
            {
                result = result * value1;
            }
            return (result);
        }

        public double root(double value1, double value2)
        {
            value1 /= 2;
            for (int i = 0; i < 100; i++)
            {
                value1 = ((value2 - 1) * value1 + value1 / Pow(value1, value2 - 1)) / value2;
                return value1;
            }
        }
        public double cos(double value1, double value2)
        {
            return value1 * value2;
        }
        public double sin(double value1, double value2)
        {
            return value1 * value2;
        }
        public double tan(double value1, double value2)
        {
            return value1 * value2;
        }
    }
}
