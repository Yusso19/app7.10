using App7._10._25.Exceptions;
using App7._10._25.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App7._10._25.Service
{
    internal class Library
    {
        public int Limit { get; set; } = 3;
        private List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }


        public void AddBook(Book book)
        {
            if (Books.Count == Limit)
            {
                throw new CapacityLimitException("Limit is full");
            }
            if (Books.Any(b => b.Name.ToLower() == book.Name.ToLower()))
            {
                throw new NotFoundException("This book already exists");
            }
            Books.Add(book);
            Console.WriteLine($"{book.Id} : Id book added");
        }

        public Book GetBookById(int? id)
        {
            if (id == null)
            {
                throw new ProductCountIsZeroException($"{id} : error empty");
            }
            var existBook = Books.FirstOrDefault(b => b.Id == id);
            if (existBook == null)
            {
                throw new NotFoundException($"{id}: not found");
            }
            return existBook;
        }
        

        public void DeleteBookById(int? id)
        {
            var existBook = GetBookById(id);
            if (existBook == null)
            {
                throw new NotFoundException($"{id}: not found");
            }
            Books.Remove(existBook);
            Console.WriteLine($"{id} : Id book deleted");
        }
    }
}
