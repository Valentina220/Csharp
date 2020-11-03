using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassShape
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] myShapes = { new Triangle(3, 4, 5), new Circle(2), new Quadrate(3) };
         
            foreach (Shape s in myShapes)
            {
                Console.WriteLine(s.ClassName());
                Console.WriteLine(s.ToString());
                //s.Perimetr();
               // s.Area();
            }
        }
    }
}
