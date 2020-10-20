using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first side of triangle");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second side of triangle");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third side of triangle");
            double c = double.Parse(Console.ReadLine());

            double p = a + b + c;
            double S = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            Console.WriteLine("Периметр\t\tПлощадь");
            Console.WriteLine($"{p:.##}" + "\t\t" + $"{S:.##}"); //("Площадь треуголинка S= ", S);
        }
    }
}
