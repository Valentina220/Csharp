using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTriangle
{
    

    class TriangleTest
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

    
}
