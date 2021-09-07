using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quanlysach.Interface;
using Quanlysach.Model;

namespace Quanlysach.Repository
{
    public class BookRepository:IRepository
    {
        public HashSet<Book> Books { get; set; } = new HashSet<Book>
        {
            new Book {Id = 1, Title = "ASP.Net", Authors = "xsd1", Publisher = "ABC1", Year = 2021},

        };
        public Book Get(int id) => Books.SingleOrDefault(b => b.Id == id);
        public bool Delete(int id)
        {
            var book = Get(id);
            return book != null ? Books.Remove(book) : false;
        }
        public Book Create()
        {
            var max = Books.Max(b => b.Id);
            var book = new Book() { Id = ++max };
            return book;
        }
        public bool Add(Book book) => Books.Add(book);
        public bool Update(Book book)
        {
            var b = Get(book.Id);
            return b != null ? Books.Remove(b) && Books.Add(book) : false;
        }
    }
}
