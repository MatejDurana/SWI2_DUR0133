using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWI2_DUR0133
{
    public class RestrictedLibrary : Library
    {
        public override void CheckOutBook(Book book, Patron patron)
        {
            if (!IsBookRestricted(book))
            {
                base.CheckOutBook(book, patron);
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available for checkout at this time in the restricted library");
            }
        }

        private bool IsBookRestricted(Book book)
        {
            List<string> restrictedBookTitles = new List<string> { "Restricted Book 1", "Restricted Book 2" };
            return restrictedBookTitles.Contains(book.Title);
        }

    }

}
