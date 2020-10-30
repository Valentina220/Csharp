using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTriangle
{
    class Triangle
    {
        public double a;
        public double b;
        public double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Triangle(double a)
        {
            this.a = a;
            this.b = a;
            this.c = a;
        }

        //public void WriteSides()
        //{
        //    Console.WriteLine("Enter the sides of triangle: ");
        //    Console.WriteLine("a= ");
        //    a = double.Parse(Console.ReadLine());
        //    Console.WriteLine("b= ");
        //    b = double.Parse(Console.ReadLine());
        //    Console.WriteLine("c= ");
        //    c = double.Parse(Console.ReadLine());

        //}

        public string isTriangle()
        {
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    //Console.WriteLine("triangle exists");
                    return "triangle exists";
                }
                else
                {
                    //Console.WriteLine("triangle doesn't exist");
                    return "triangle doesn't exist";
                }
            }
        }

        public double Perimetr()
        {
            return a + b + c;
        }

        public double Square()
        {
            return Math.Sqrt(Perimetr() * (Perimetr() - a) * (Perimetr() - b) * (Perimetr() - c));
        }

        //public void PrintSides()
        //{
        //    Console.WriteLine("a is {0}, b is {1}, c is {2}", a, b, c);
        //}

        public void Print()
        {
            //Console.WriteLine("Perimetr = {0}", Perimetr());
            //Console.WriteLine("Square = {0}", Square());
            Console.WriteLine("a is {0}, b is {1}, c is {2}\n", a, b, c);
        }
    }
}
