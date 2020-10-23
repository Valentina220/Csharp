using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetShooting
{
    class TargetShooting
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Сколько раз будете стрелять? ");
                double n = double.Parse(Console.ReadLine());

                double score = 0;
                int i = 0;

                 while (i < n)
                { Console.WriteLine("Введите x: ");
                 double x = double.Parse(Console.ReadLine());

                 Console.WriteLine("Введите y: ");
                double y = double.Parse(Console.ReadLine());


                //bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0); int maxDayNum = isLeapYear ? 366 : 365;

                //bool sector1 = ((x * x + y * y) <= 4) && ((x * x + y * y) >= 1);

                //int maxDayNum = isLeapYear ? 366 : 365;

                //Console.WriteLine(x);
                //Console.WriteLine(y);
                
                //bool sector1 = (x * x + y * y <= 4 && x * x + y * y >= 1);

                //double a = x * x + y * y;
                //Console.WriteLine(a);



                if (x * x + y * y <= 4 && x * x + y * y >= 1)                   
                    score = score + 5;
                else if  (x * x + y * y < 1 && y >= 0 && x >= 0)
                    score = score + 10;
                else
                    score = score + 0; 
            
                i++;    

                 }

            Console.WriteLine("Вы набрали {0} очков", score);



            //Console.WriteLine("вне");
            //else Console.WriteLine("на границе");
            
            
                      
         }
            

            

            

           


        
    }
}
