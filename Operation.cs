using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea1
{
    class Operation
    {
        public static double TriangelArea(double a, double b, double c)
        {
            double p = a + b + c;
            double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));

            return S;
            
        }

        public static double TriangelArea1(double a)
        {
            double p1 = 3*a;
            double S1 = Math.Sqrt(p1 * 3*(p1 - a));

            return S1;

        }

        public static bool TriangleCheck(double a, double b, double c, out bool result)
        {
            if (a + b > c && b + c > a && c + a > b)
                result = true;
            else result = false;
            return result;
        }

    }
}
