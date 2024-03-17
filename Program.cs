namespace SWI2_DUR0133
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book
            {
                Title = "The Great Gatsby",
                Author = "F. Scott Fitzgerald",
                ISBN = "9780743273565",
                Genre = "Classic",
                IsAvailable = true
            };

            Book book2 = new Book
            {
                Title = "To Kill a Mockingbird",
                Author = "Harper Lee",
                ISBN = "9780061120084",
                Genre = "Classic",
                IsAvailable = true
            };

            Patron patron1 = new Patron
            {
                Name = "John Doe",
                LibraryCardNumber = 12345
            };

            Library library = new Library();
            library.Books.Add(book1);
            library.Books.Add(book2);

            library.CheckOutBook(book1, patron1);

            library.ReturnBook(book1, patron1);

            Console.WriteLine($"Is {book1.Title} available after returning? {book1.IsAvailable}");
        }
    }
}
