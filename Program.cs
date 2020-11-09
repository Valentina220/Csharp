using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceOverload
{
    public class Distance
    {
        public int ft;
        public double inch;
        
        public Distance(int ft, double inch)
        {
            this.ft = ft;
            this.inch = inch;
        }
        public Distance() 
        { }

        public static Distance operator +(Distance d1, Distance d2)
        {
            return new Distance { ft = d1.ft + d2.ft + (int)((d1.inch + d2.inch) / 12), inch = (d1.inch + d2.inch)%12 };            
        }

        public static Distance operator -(Distance d1, Distance d2)
        {
            if (d1.inch > d2.inch)
            {
                return new Distance { ft = d1.ft - d2.ft, inch = d1.inch - d2.inch };
            }
            else
            {
                return new Distance { ft = (d1.ft-1) - d2.ft, inch = (d1.inch + 12) - d2.inch };
            }
            
        }         

    }

    class Program
    {
        static void Main(string[] args)
        {
            Distance dist1 = new Distance(13, 5);
            Distance dist2 = new Distance(7, 8);           

            Distance dist3 = dist1 + dist2;
            Distance dist4 = dist1 - dist2;


            Console.WriteLine("Результат сложения\n");
            Console.WriteLine("{0}' - {1}''\n", + dist3.ft, +dist3.inch);
            Console.WriteLine("Результат вычитания\n");
            Console.WriteLine("{0}' - {1}''\n", +dist4.ft, +dist4.inch);            

        }
    }

}
