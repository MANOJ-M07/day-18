using System;
using Booklib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            int opt;

            do
            {
                Console.WriteLine("******Library Management System*******");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. View all books");
                Console.WriteLine("3. Search by ID");
                Console.WriteLine("4. Search by title");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        int bookId = int.Parse(Console.ReadLine());

                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Is Available (true/false): ");
                        bool isAvailable = bool.Parse(Console.ReadLine());

                        Book newBook = new Book
                        {
                            BookId = bookId,
                            Title = title,
                            Author = author,
                            Genre = genre,
                            IsAvailable = isAvailable
                        };
                        library.AddBook(newBook);
                        Console.WriteLine("Book added successfully!!!!!!");
                        break;


                    case 2:
                        library.ViewAllBooks();
                        break;

                    case 3:
                        Console.Write("Enter Book ID to search: ");
                        int searchBookId = int.Parse(Console.ReadLine());
                        library.SearchBookById(searchBookId);
                        break;

                    case 4:
                        Console.Write("Enter Title to search: ");
                        string searchTitle = Console.ReadLine();
                        library.SearchBookByTitle(searchTitle);
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice!!!!");
                        break;
                }

                Console.ReadKey();
            } while (opt != 5);
        }
    }
}
