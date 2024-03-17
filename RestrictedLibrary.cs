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
            Console.WriteLine($"{patron.Name} is trying to check out {book.Title} from a restricted library.");
            if (book.IsAvailable)
            {
                base.CheckOutBook(book, patron);
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available for checkout at this time");
            }
        }
    }
}
