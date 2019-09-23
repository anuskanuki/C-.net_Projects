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
        private int idCount = 1001;

        private List<Book> BooksList { get; set; }

        public BooksController()
        {
            BooksList = new List<Book>();
        }
        public List<Book> ReturnsBookList()
        {
            return BooksList;
        }

        /// <summary>
        /// This method add the book in our already created list, inside the constructor
        /// </summary>
        /// <param name="bookParam">Inserted book information</param>
        public void AddBook(Book bookParam)
        {
            bookParam.CreationDate = DateTime.Now;
            bookParam.Id = idCount++;
            BooksList.Add(bookParam);
        }



    }
}
