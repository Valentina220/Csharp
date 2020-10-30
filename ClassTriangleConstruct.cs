using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTriangle
{
    

    class ClassTriangle
    {
        static void Main(string[] args)
        {
            Triangle Tr1 = new Triangle(3, 4, 5);
            Triangle Tr2 = new Triangle(3, 3, 3);

            //Console.WriteLine("Enter the sides of triangle: ");
            //Console.WriteLine("a= ");
            //Obj.a = double.Parse(Console.ReadLine());
            //Console.WriteLine("b= ");
            //Obj.b = double.Parse(Console.ReadLine());
            //Console.WriteLine("c= ");
            //Obj.c = double.Parse(Console.ReadLine());

            Console.WriteLine("Triangle 1: \n");
            //Tr1.WriteSides();
            Console.WriteLine(Tr1.isTriangle());
            Console.WriteLine("Perimetr = " + Tr1.Perimetr());
            Console.WriteLine("Square = " + $"{Tr1.Square():.##}");
            //Tr1.Square();
            Tr1.Print();

            Console.WriteLine("Triangle 2: \n");
            Console.WriteLine(Tr2.isTriangle());
            Console.WriteLine("Perimetr = " + Tr2.Perimetr()); 
            Console.WriteLine("Square = " + $"{Tr2.Square():.##}");
            //Tr2.Square();
            Tr2.Print();


        }
    }

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
