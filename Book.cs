using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{

    class Book : IComparable
    {
        private string author;
        private string title;
        private int pages;
        private int year;


        public Book(String author, String title, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
            Console.WriteLine(author + title + pages + year);
        }

        public override string ToString()
        {
            return author + " " + title + " " + pages + " " + year;
        }


        int IComparable.CompareTo(object obj)
        {
            Book it = (Book)obj;
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;
        }

        public void Show()
        {
            Console.WriteLine("\nКнига:\n Автор: {0}\n Название: {1}\n {2} стр.\n Год издания: {3}\n ", author, title, pages, year);
        }

    }    
}
