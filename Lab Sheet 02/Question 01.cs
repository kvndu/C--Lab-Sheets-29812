using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_sheet
{
    internal class Program
    {
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
        }

        static void Main(string[] args)
        {
            Book myBook = new Book();

            myBook.Title = "Aba yaluwo";
            myBook.Author = "Martin wickramasingha";

            Console.WriteLine("Book Title: " + myBook.Title);
            Console.WriteLine("Book Author: " + myBook.Author);

            Console.ReadLine();
        }
    }
}
