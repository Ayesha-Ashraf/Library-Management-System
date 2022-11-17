using Library_Management__System.Model;
using Library_Management__System.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace Library_Management__System.Pages
{
    public class BookModel : PageModel
    {
        // Need variable for service
        jsonfileBookService BookService;

        // Need variable for Book Record
        public IEnumerable<Book> Books;
        private readonly ILogger<BookModel> _logger;

        public BookModel(ILogger<BookModel> logger, jsonfileBookService service)
        {
            _logger = logger;
            BookService = service;
        }

        public void OnGet()
        {
            Books = BookService.getBookRecord();
        }
    }
}

