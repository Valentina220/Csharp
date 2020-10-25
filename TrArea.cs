using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea1
{
    class TrArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Треугольник равносторонний? (Введите 1, если да, и 0, если нет)");
            int ans = int.Parse(Console.ReadLine());
            
            if (ans == 1)
            {
                Console.WriteLine("Введите сторону треугольника: ");
                double side = double.Parse(Console.ReadLine());

                double Area1 = Operation.TriangelArea1(side);
                Console.WriteLine("Площадь треугольника =  " + $"{Area1:.##}");

            }

            else
            {
                Console.WriteLine("Введите первую сторону треугольника: ");
                double side1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите вторую сторону треугольника: ");
                double side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите третью сторону треугольника: ");
                double side3 = double.Parse(Console.ReadLine());


                bool Checking = Operation.TriangleCheck(side1, side2, side3, out bool result);

                if (result == true)
                {
                    double Area = Operation.TriangelArea(side1, side2, side3);
                    Console.WriteLine("Площадь треугольника =  " + $"{Area:.##}");

                    //Console.WriteLine("Такой треугольник существует");
                }
                else
                {
                    Console.WriteLine("Такого треугольника не существует");
                    return;
                }


                //double Area = Operation.TriangelArea(side1, side2, side3);
                //Console.WriteLine("Площадь треугольника =  " + $"{Area:.##}");
            }
           

        }
        
    }
}

