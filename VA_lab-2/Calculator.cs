using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA_lab_2
{
    class Calculator
    {
        public static double Sqrt(double x)
        {
            double result = x;
            while (Math.Abs(Math.Pow(result, 2) - x) > 0.000000000000001)
            {
                result = (result + (x / result)) / 2;
            }
            return result;
        }

        public static double Cos(double x)
        {
            double v1 = 1;
            double result = 0;
            double current = v1;
            long k = 1;
            while (Math.Abs(current) > 0)
            {
                result += current;
                current = -(Math.Pow(x, 2) / (2 * k * (2 * k - 1))) * current;
                k++;
            }
            return result;
        }

        public static double Sin(double x)
        {
            double u1 = x;
            double result = 0;
            double current = u1;
            long k = 1;
            while (Math.Abs(current) > 0)
            {
                result += current;
                current = -(Math.Pow(x, 2) / (2 * k * (2 * k + 1))) * current;
                k++;
            }
            return result;
        }

        public static double Ln(double z)
        {
            double u0 = (1 - z) / (1 + z);
            double result = 0;
            double current = u0;
            int k = 1;
            while (Math.Abs(current) > 0)
            {
                result += current;
                double x1 = 1d / (2 * k + 1);
                double x2 = Math.Pow(u0, 2 * k + 1);
                current = x1 * x2;
                k++;
            }
            return -2 * result;
        }

        public static double Exp(double x)
        {
            double result = 0;
            long k = 1;
            double current = 1;
            while (Math.Abs(current) > 0)
            {
                result += current;
                current = (x / k) * current;
                k++;
            }
            return result;
        }
    }
}
