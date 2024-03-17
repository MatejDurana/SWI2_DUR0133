﻿using SWI2_DUR0133;
using System;
using System.Collections.Generic;

public class Library
{
    public List<Book> Books { get; set; }

    public Library()
    {
        Books = new List<Book>();
    }

    public virtual void CheckOutBook(Book book, Patron patron)
    {
        if (book.IsAvailable)
        {
            Console.WriteLine($"{book.Title} has been checked out by {patron.Name}");
            book.IsAvailable = false;
            patron.BooksCheckedOut.Add(book);
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
            Console.WriteLine($"{book.Title} has been returned by {patron.Name}");
            patron.BooksCheckedOut.Remove(book);
            book.IsAvailable = true;
        }
        else
        {
            Console.WriteLine($"{patron.Name} does not have {book.Title} checked out");
        }
    }
}
