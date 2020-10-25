using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{

    public struct Distance
    {
        public double ft;
        public double inch;
        public double distance;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Distance d1, d2;
            Console.WriteLine("Введите футы: ");
            d1.ft = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите дюймы: ");
            d1.inch = double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите футы: ");
            //d2.ft = double.Parse(Console.ReadLine());
            //Console.WriteLine("Введите дюймы: ");
            //d2.inch = double.Parse(Console.ReadLine());

            d1.distance = d1.ft + (int)(d1.inch / 12);
            d2.distance = d1.inch % 12;

            Console.WriteLine("{0}' - {1}''", + d1.distance, + d2.distance);

            //d1.distance = d1.ft + d2.ft;
            //d2.distance = d1.inch + d2.inch;

           
        }
    }
}
