using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Manager: Person
    {
        //private string Faculty;
       

        public Manager(string LastName, string DateOfBirth, string Faculty, double Experience) : base(LastName, DateOfBirth, Experience, Faculty)
        {
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Faculty = Faculty;            
            this.Experience = Experience;
        }

        public override void Show()
        {
            Console.WriteLine("\n Фамилия: {0}\n Дата рождения: {1}\n Факультет: {2}\n Стаж : {3}\n", LastName, DateOfBirth, Faculty, Experience);
        }

        public override string ClassName()
        {
            string name = "Менеджер";
            return name;
        }
        public override string Work()
        {
            return "Cчитай и выплачивай!\n";
        }

        //Должен ли стулент получать стипендию
        public string Stipend(double AverageScore)
        {
            if (AverageScore >= 4.5)
            {
                return "Назначить стипендию";
            }
            else
            {
                return "Cтипендию не назначать";
            }
        }

        public double StipendPayment(double AverageScore)
        {
            double pay = 0;
            if (AverageScore >= 4.5 && AverageScore < 4.75)
            {
                pay = 3500 * 1;       // 3500 - базовая стипендия
            }
            else if (AverageScore >= 4.75 && AverageScore < 5)
            {
                pay = 3500 * 1.4;
            }
            else if (AverageScore == 5)
            {
                pay = 3500 * 1.8;
            }
            return pay;
        }

        public double Premium(double Experience)
        {
            double pay = 0;
            if (Experience > 20)
            {
                pay = 40000;
            }
            return pay;
        }
    }
}
