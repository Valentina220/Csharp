using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace University
{
    class Student: Person, IEmployee
    {
        //private string LastName;
        //private string DateOfBirth;
        //private DateTime DateOfBirth = new DateTime(1996, 7, 19);        
        //private string Faculty;
        //private double Course;

        private double Group;
        private double AverageScore;        
        private double DeptNumber;   //количество долгов

        //private struct DateOfBirth
        //{
        //    private double date;
        //    private double month;
        //    private double year;
        //}

        public Student(string LastName, string DateOfBirth, string Faculty, double Group, double AverageScore, double Experience, double DeptNumber): base (LastName, DateOfBirth, Experience, Faculty)   //, DateTime DateOfBirth)
        {
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Faculty = Faculty;
            this.Group = Group;
            this.AverageScore = AverageScore;
            //base.Experience = Course;
            this.Experience = Experience;  //курс
            this.DeptNumber = DeptNumber;
        }

        public override void Show()
        {
           Console.WriteLine("\n Фамилия: {0}\n Дата рождения: {1}\n Факультет: {2}\n Группа : {3}\n Средний балл: {4}\n Курс: {5}\n Количество долгов: {6}\n", LastName, DateOfBirth, Faculty, Group, AverageScore, Experience, DeptNumber);
        }          


        public override string ClassName()
        {
            string name = "Студент";
            return name;
        }
        public override string Work()
        {
            if(Experience == 4 || Experience == 6)
            {
                return "Пиши ВКР!\n";
            }
            else
            {
                return "Учись, студент!\n";
            }
            
        }

        public string ResearchActivities()
        {
            return "Занимайтесь исследованиями и разработками!";
        }
    }
}
