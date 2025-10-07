using App7._10._25.Models;
using App7._10._25.Service;
using App7._10._25.Exceptions;
using System;

class Program
{
    static void Main(string[] args)
    {
        var library = new Library();

        try
        {
            // Create books
            var book1 = new Book { Id = 1, Name = "C# for Beginners", Price = 500, Count = 2, Author = "Ivanov", PageCount = 350 };
            var book2 = new Book { Id = 2, Name = "ASP.NET Core", Price = 700, Count = 1, Author = "Petrov", PageCount = 420 };

            // Add books
            library.AddBook(book1);
            library.AddBook(book2);

            // Get book by Id
            var foundBook = library.GetBookById(1);
            foundBook.ShowInfo();

            // Delete book
            library.DeleteBookById(2);

            // Try to add a book with the same name (will throw exception)
            library.AddBook(new Book { Id = 3, Name = "C# for Beginners", Price = 600, Count = 1, Author = "Sidorov", PageCount = 300 });
        }
        catch (CapacityLimitException ex)
        {
            Console.WriteLine($"Limit: {ex.Message}");
        }
        catch (NotFoundException ex)
        {
            Console.WriteLine($"Not found: {ex.Message}");
        }
        catch (ProductCountIsZeroException ex)
        {
            Console.WriteLine($"Count error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Other error: {ex.Message}");
        }
    }
}