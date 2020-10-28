using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTriangle
{
    

    class Program
    {
        static void Main(string[] args)
        {
            Triangle Obj = new Triangle();

            //Console.WriteLine("Enter the sides of triangle: ");
            //Console.WriteLine("a= ");
            //Obj.a = double.Parse(Console.ReadLine());
            //Console.WriteLine("b= ");
            //Obj.b = double.Parse(Console.ReadLine());
            //Console.WriteLine("c= ");
            //Obj.c = double.Parse(Console.ReadLine());

            Obj.WriteSides();
            Obj.isTriangle();
            Obj.Perimetr();
            Obj.Square();
            Obj.Print();

        }
    }

    class Triangle
    {
        public double a;
        public double b;
        public double c;

        public void WriteSides()
        {
            Console.WriteLine("Enter the sides of triangle: ");
            Console.WriteLine("a= ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            c = double.Parse(Console.ReadLine());

        }

        public bool isTriangle()
        {            
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    Console.WriteLine("triangle exists");
                    return true;
                }
                else
                {
                    Console.WriteLine("triangle doesn't exist");
                    return false;
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
            Console.WriteLine("Perimetr = {0}", Perimetr());
            Console.WriteLine("Square = {0}", Square());
            Console.WriteLine("a is {0}, b is {1}, c is {2}", a, b, c);
        }
    }
}
