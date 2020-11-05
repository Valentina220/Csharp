using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    abstract class Person
    {
        protected string LastName;
        protected string DateOfBirth;
        protected double Experience;    // Стаж
        protected string Faculty;

        public Person(string LastName, string DateOfBirth, double Experience, string Faculty)
        {
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Experience = Experience;
            this.Faculty = Faculty;
        }

        public abstract string Work();

        public abstract string ClassName();

        public abstract void Show();

        //public override string ToString()
        //{
        //    Console.WriteLine(Show());
        //}
    }
}
