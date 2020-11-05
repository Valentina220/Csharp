using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Lecturer: Person
    {
        //private string LastName;
        //private string DateOfBirth;
        //private DateTime DateOfBirth = new DateTime(1953, 10, 9);
        //private double Experience;  // Стаж
        //private string Faculty;

        private string AcademicDegree;    //должность
        

        public Lecturer(string LastName, string DateOfBirth, string Faculty, string AcademicDegree, double Experience) : base (LastName, DateOfBirth, Experience, Faculty)
        {
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Faculty = Faculty;
            this.AcademicDegree = AcademicDegree;
            this.Experience = Experience;
        }

        public override void Show()
        {
            Console.WriteLine("\n Фамилия: {0}\n Дата рождения: {1}\n Факультет: {2}\n Ученая степень : {3}\n Стаж: {4}\n", 
                LastName, DateOfBirth, Faculty, AcademicDegree, Experience);
        }

        public override string ClassName()
        {
            string name = "Преподаватель";
            return name;
        }
        public override string Work()
        {
            return "Учи студентов!\n";
        }
    }

   
}