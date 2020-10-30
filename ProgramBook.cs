using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Book Bk1 = new Book("Оруэл Дж ", "Скотный двор ", 256 , 2019);
            //Console.WriteLine(Bk1.ToString());
            Book Bk2 = new Book("Сартр Ж.П.", "Стена", 285, 2017);
            //Console.WriteLine(Bk2.ToString());
            Book Bk3 = new Book("Фромм Э. ", "Иметь или быть? ", 320 , 2020);
            //Console.WriteLine(Bk3.ToString());

            Bk1.Show();
            Bk2.Show();
            Bk3.Show();

            //Console.WriteLine("Введите количество книг:");
            //int num = int.Parse(Console.ReadLine());
            //int[] a = new int[num];

            //Console.WriteLine("Введите данные о книгах: ");

            //for (int i = 0; i < a.GetLength(0); i++) 
            //{
            //    Console.WriteLine("Введите имя автора: ");
            //    string author = (Console.ReadLine());
            //    Console.WriteLine("Введите название книги: ");
            //    string title = (Console.ReadLine());
            //    Console.WriteLine("Введите количество страниц: ");
            //    string pages = (Console.ReadLine());
            //    Console.WriteLine("Введите год издания: ");
            //    string year = (Console.ReadLine());

            //    Bk.SetBook(author, title, pages, year);
            //    Bk.Sort();
            //    Bk.CompareTo();
            //}
            Book[] arrBook = { Bk1, Bk2, Bk3 };
            Array.Sort(arrBook);
            foreach (var item in arrBook)
            {
                Console.WriteLine(item);
            }

            //static string CompareAuthors(Book Book1, Person Book2)
            //{
            //    bool equalParams = person1.Equals(person2);
            //    Object personobj = person1;
            //    bool fullEqual = personobj.Equals(person2);

            //    if (fullEqual)
            //        return "Абсолютно одинаковые объекты";
            //    if (equalParams)
            //        return "Одинаковые свойства объектов";

            //    return "Объекты разные";
            //}
        }
    }

    

}

