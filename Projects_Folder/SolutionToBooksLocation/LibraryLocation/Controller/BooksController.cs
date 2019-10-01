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
        private LocationContext DataBaseContext = new LocationContext();

        public List<Book> ReturnsBookList()
        {
            //where "active" is true,will return!
            return DataBaseContext.BooksList.Where(x => x.Active).ToList<Book>();
        }

        #region Add/Delete Book
        /// <summary>
        /// This method add the book in our already created list, inside the constructor
        /// </summary>
        /// <param name="bookParam">Inserted book information</param>
        public void AddBook(Book bookParam)
        {
            bookParam.CreationDate = DateTime.Now;
            bookParam.Id = DataBaseContext.IdCountBooks++;
            DataBaseContext.BooksList.Add(bookParam);
        }
        /// <summary>
        /// Disable the sinalized book register
        /// </summary>
        /// <param name="bookId"></param>
        public void DeleteBookByID(int bookId)
        {
            //first or default returns null in case he doesn't find the register
            var bookHere = DataBaseContext.BooksList.FirstOrDefault(x => x.Id == bookId);
            if (bookHere != null) //exception treatment
                bookHere.Active = false;
        }
        #endregion
    }
}
