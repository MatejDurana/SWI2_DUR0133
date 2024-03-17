using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWI2_DUR0133
{
    public class Patron
    {
        public string Name { get; set; }
        public int LibraryCardNumber { get; set; }
        public List<Book> BooksCheckedOut { get; set; }

        public Patron()
        {
            BooksCheckedOut = new List<Book>();
        }
    }

}
