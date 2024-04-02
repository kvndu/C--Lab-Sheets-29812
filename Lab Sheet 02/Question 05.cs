using System;
using System.Collections.Generic;

namespace lab_sheet
{
    public class LibraryBook
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public bool Available { get; set; } = true;

        public void BorrowBook()
        {
            if (Available)
            {
                Available = false;
                Console.WriteLine($"{Title} by {Author} has been borrowed.");
            }
            else
            {
                Console.WriteLine($"{Title} by {Author} is not available for borrowing.");
            }
        }

        public void ReturnBook()
        {
            Available = true;
            Console.WriteLine($"{Title} by {Author} has been returned.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<LibraryBook> books = new List<LibraryBook>()
            {
                new LibraryBook { Title = "Gamperaliya", Author = "Martin Wickramasinghe" },
                new LibraryBook { Title = "Ape Gama", Author = "Martin Wickramasinghe" },
                new LibraryBook { Title = "Aba Yaluwo", Author = "Martin Wickramasinghe" }
            };

            int choice;

            do
            {
                Console.WriteLine("\nLibrary Menu:");
                Console.WriteLine("1. Borrow a Book");
                Console.WriteLine("2. Return a Book");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        BorrowBook(books);
                        break;
                    case 2:
                        ReturnBook(books);
                        break;
                    case 3:
                        Console.WriteLine("Exiting Library System.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }

            } while (choice != 3);
        }

        static void BorrowBook(List<LibraryBook> books)
        {
            Console.WriteLine("\nBook List:");
            int index = 1;
            foreach (var book in books)
            {
                Console.WriteLine($"{index}. {book.Title} by {book.Author} - Available: {book.Available}");
                index++;
            }

            Console.Write("Enter the number of the book you want to borrow: ");
            int selection = Convert.ToInt32(Console.ReadLine()) - 1;

            if (selection >= 0 && selection < books.Count)
            {
                books[selection].BorrowBook();
            }
            else
            {
                Console.WriteLine("Invalid book selection.");
            }
        }

        static void ReturnBook(List<LibraryBook> books)
        {
            Console.WriteLine("\nBook List:");
            int index = 1;
            foreach (var book in books)
            {
                Console.WriteLine($"{index}. {book.Title} by {book.Author} - Available: {book.Available}");
                index++;
            }

            Console.Write("Enter the number of the book you want to return: ");
            int selection = Convert.ToInt32(Console.ReadLine()) - 1;

            if (selection >= 0 && selection < books.Count)
            {
                books[selection].ReturnBook();
            }
            else
            {
                Console.WriteLine("Invalid book selection.");
            }
        }
    }
}
