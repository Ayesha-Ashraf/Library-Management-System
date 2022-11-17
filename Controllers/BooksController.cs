using Library_Management__System.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Library_Management__System.Model;
using Library_Management__System.Services;
using System.Collections.Generic;

namespace Library_Management__System.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        jsonfileBookService BookService { get; }
        public BooksController(jsonfileBookService bookService)
        {
            this.BookService = bookService;
        }
        public IEnumerable<Book> Get()
        {
            return BookService.getBookRecord();
        }
    }
}