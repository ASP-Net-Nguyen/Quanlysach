using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Quanlysach.Model;
using Quanlysach.Interface;

namespace Quanlysach.Pages
{
    public class BookModel : PageModel
    {
        public enum Action { Details, Create, Update, Delete}
        private readonly IRepository _repository;
        public BookModel(IRepository repository) => _repository = repository;
        public Action Job { get; private set; }
        public Book Book { get; private set; }
        public void OnGet(int id)
        {
            Job = Action.Details;
            Book = _repository.Get(id);
            ViewData["Title"] = Book == null ? "not found" : $"Details - {Book.Title}";
        }
    }
}
