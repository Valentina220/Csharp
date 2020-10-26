using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class EquationSolution
    {

        //public struct RootsOfEq
        //{
        //    public double x1;
        //    public double x2;
        //    public bool checkroots;
        //}

        //public static double RootsFinding(double a, double b, double c, out RootsOfEq) //out QuadraticEquation.EquationSolution.RootsOfEq) //out double x1, out double x2)
        //{
        //    //x1 = 0;
        //    //x2 = 0;

        //    RootsOfEq root, check;

        //    double D = b * b - 4 * a * c;


        //    if (D > 0)
        //    {
        //        check.checkroots = true;
        //        root.x1 = (b * b + Math.Sqrt(D)) / (2 * a);
        //        root.x2 = (b * b - Math.Sqrt(D)) / (2 * a);
        //    }
        //    else if (D == 0)
        //    {
        //        check.checkroots = true;
        //        root.x1 = root.x2 = -b / (2 * a);
        //    }
        //    else
        //    {
        //        check.checkroots = false;
        //        //Console.WriteLine("Корней нет")
        //            //return 0;
        //    }

        //}


        public static double Checking(double a, double b, double c, out int checkres, out double x1, out double x2)
        {
            x1 = 0;
            x2 = 0;

            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                checkres = 1;
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);                
               
            }
            else if (D == 0)
            {
                checkres = 0;
                x1 = x2 = -b / (2 * a);
            }
            else
            {
                checkres = -1;
            }
            return checkres;
           
                
        }

      
    }
}
