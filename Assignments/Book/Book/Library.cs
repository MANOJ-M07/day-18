using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booklib
{
    public class Library
    {
        static List<Book> books;

        public Library()
        {
            books = new List<Book>();
        }

        public void AddBook(Book bk)
        {
            books.Add(bk);
        }

        public void ViewAllBooks()
        {
            foreach (var bk in books)
            {
                Console.WriteLine($"Book ID: {bk.BookId},\nTitle: {bk.Title},\nAuthor: {bk.Author},\nGenre: {bk.Genre},\nAvailable: {bk.IsAvailable}");
            }
        }
        public void SearchBookById(int bookId)
        {
            var bk = books.Find(b => b.BookId == bookId);
            if (bk != null)
            {
                Console.WriteLine($"Book ID: {bk.BookId},\nTitle: {bk.Title},\nAuthor: {bk.Author},\nGenre: {bk.Genre},\nAvailable: {bk.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book not found!!!!!!!!");
            }
        }

        public void SearchBookByTitle(string title)
        {
            var bk = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bk != null)
            {
                Console.WriteLine($"Book ID: {bk.BookId},\nTitle:  {bk.Title} ,\nAuthor:  {bk.Author} ,\nGenre:  {bk.Genre} ,\nAvailable: {bk.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book not found!!!!!!!!");
            }
        }
    }
}
