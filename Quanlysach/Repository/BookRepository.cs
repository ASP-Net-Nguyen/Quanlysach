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
            new Book {Id = 1, Title = "ASP.Net", Publisher = "ABC1", Year = 2021, Authors = "xsd1"},
            new Book {Id = 2, Title = "ASP.Net", Publisher = "ABC2", Year = 2021, Authors = "xsd2"},
            new Book {Id = 3, Title = "ASP.Net", Publisher = "ABC3", Year = 2021, Authors = "xsd3"},
            new Book {Id = 4, Title = "ASP.Net", Publisher = "ABC4", Year = 2021, Authors = "xsd4"},
            new Book {Id = 5, Title = "ASP.Net", Publisher = "ABC5", Year = 2021, Authors = "xsd5"},
            new Book {Id = 6, Title = "ASP.Net", Publisher = "ABC6", Year = 2021, Authors = "xsd6"},
        };
        public Book Get(int id) => Books.SingleOrDefault(b => b.Id == id);
        public bool Delete(int id)
        {
            var book = Get(id);
            return book != null ? Books.Remove(book) : false;
        }
    }
}
