using Library_Management__System.Model;
using Library_Management__System.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Management__System.Pages
{

  
  public class IndexModel : PageModel
        {
            // Need variable for service
            jsonfileBookService BookService;

            // Need variable for Book Record
            public IEnumerable<Book> Books;
            private readonly ILogger<IndexModel> _logger;

            public IndexModel(ILogger<IndexModel> logger, jsonfileBookService service)
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

