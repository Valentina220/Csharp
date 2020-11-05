using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    
    class Dean: Person    //Декан
    {
        //private string LastName;
        //private string DateOfBirth;
        //private DateTime DateOfBirth = new DateTime(1968, 4, 23);
        //private string Faculty;
        private string AcademicDegree;    //Ученая степень

        public Dean(string LastName, string DateOfBirth, string Faculty, string AcademicDegree, double Experience) : base(LastName, DateOfBirth, Experience, Faculty)
        {
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Faculty = Faculty;
            this.AcademicDegree = AcademicDegree;
            this.Experience = Experience;
        }

        public override void Show()
        {
            Console.WriteLine("\n Фамилия: {0}\n Дата рождения: {1}\n Факультет: {2}\n Ученая степень : {3}\n Стаж : {4}\n", LastName, DateOfBirth, Faculty, AcademicDegree, Experience);
        }

        //public string Remand(double DeptNumber)
        //{
        //    if (isDept(DeptNumber))
        //    {                
        //        return "Отчислить";               
        //    }            
        //}

        public override string ClassName()
        {
            string name = "Декан";
            return name;
        }
        public override string Work()
        {
            return "Руководи и учи!\n";
        }

        public string isDept(double DeptNumber)
        {
            if (DeptNumber >= 5)
            {
                return "Отчислить";
            }
            else
            {
                return "Не подлежит отчислению";
            }
        }
     
    }
}
