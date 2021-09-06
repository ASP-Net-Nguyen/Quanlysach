using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Quanlysach.Model
{
    public class Book
    {
        public int Id { get; set; }
        public String Title { get; set; } = "A new book";
        public String Authors { get; set; } = "Authors";
        public String Publisher { get; set; } = "Publisher";
        public int Year { get; set; } = DateTime.Now.Year;
        public String Description { get; set; } = "";
    }
}
