using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWI2_DUR0133
{
    public class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void CheckOutBook(Book book, Patron patron)
        {
            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                patron.BooksCheckedOut.Add(book);
                Console.WriteLine($"{book.Title} has been checked out by {patron.Name}");
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available for checkout");
            }
        }

        public void ReturnBook(Book book, Patron patron)
        {
            if (patron.BooksCheckedOut.Contains(book))
            {
                patron.BooksCheckedOut.Remove(book);
                book.IsAvailable = true;
                Console.WriteLine($"{book.Title} has been returned by {patron.Name}");
            }
            else
            {
                Console.WriteLine($"{patron.Name} does not have {book.Title} checked out");
            }
        }
    }

}
