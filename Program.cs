using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] myPerson = { new Student("Иванов", "13.04.1998","ФКиО", 1161, 4.6, 5, 0), new Lecturer("Бабаев", "28.11.1965","ФКиО", "д.т.н.", 32), 
                new Dean("Рюмин","11.03.1972","ФКиО","к.т.н.", 25), new Manager("Куркин","15.01.1981","ФКиО", 9) };

            foreach (Person p in myPerson)
            {
                Console.WriteLine(p.ClassName());
                p.Show();
                Console.WriteLine(p.Work());                                             
            }            
        }
    }
}
