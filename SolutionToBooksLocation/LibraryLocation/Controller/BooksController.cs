using LibraryLocation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLocation.Controller
{
    public class BooksController
    {
        public List<Book> Books { get; set; }

        public BooksController()
        {
            Books = new List<Book>();


            Books.Add(new Book()
            {
                Name = "My first book"
            });

            Books.Add(new Book()
            {
                Name = "My second book"
            });
        }  


    }
}
