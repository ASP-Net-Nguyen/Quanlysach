using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Quanlysach.Model;

namespace Quanlysach.Interface
{
    public interface IRepository
    {
        public HashSet<Book> Books { get; set; }
        public Book Get(int id);
        public bool Delete(int id);
        public Book Create();
        public bool Add(Book book);
    }
}
