using Library_Management__System.Model;
using Microsoft.AspNetCore.Hosting;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace Library_Management__System.Services
{
    
    public class jsonfileBookService
    {
        // Json -> Program
        // Need a vraiable for home/root address & then generate file address & then do file handling

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        // Set Actual Hosting Environment  E.g: [Here We don't know the environment](?) / Our file name
        public jsonfileBookService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        // Generate File Address
        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Book.json");
            }
        }

        // File Handling
        public IEnumerable<Book> getBookRecord()
        {
            using (var filestream = File.OpenText(fileAddress))
            {
                return JsonSerializer.Deserialize<Book[]>(filestream.ReadToEnd());
            }
        }
    }
}

