using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Quadr
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициенты квадратного уравнения");
            Console.WriteLine("a= ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("b= ");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("c= ");
            double z = double.Parse(Console.ReadLine());

            

            double check = EquationSolution.Checking(x, y, z, out int checkres, out double x1, out double x2);

            if (check == 1)
            {
                Console.WriteLine("Корни уравнения с коэффициентами a = {0}, b = {1}, c = {2} равны: x1 = {3}, x2 = {4}", +x, +y, +z, +x1, +x2);

            }
            else if (check == 0)
            {
                Console.WriteLine("Корень уравнения с коэффициентами a = {0}, b = {1}, c = {2} один: x1 = x2 = {3}", +x, +y, +z, +x1);
            }
            else
            {
                Console.WriteLine("Корней уравнения с коэффициентами a = {0}, b = {1}, c = {2} нет",+x, +y, +z);
            }

            //Console.WriteLine(check);
            
        }
    }
}
