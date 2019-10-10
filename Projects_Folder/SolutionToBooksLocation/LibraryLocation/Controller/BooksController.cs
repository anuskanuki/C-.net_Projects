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

        SystemContextDB contextDB = new SystemContextDB();

        #region CRUD
        //CRUD
        //CREATE
        public bool AddBook(Book itemBook)
        {
            //validations
            if (string.IsNullOrWhiteSpace(itemBook.Name))
                return false;

            contextDB.Books.Add(itemBook);//insert into books list
            contextDB.SaveChanges();
            return true;
        }

        //READ
        public IQueryable<Book> GetBooks()
        {
            return contextDB.Books.Where(x => x.Active == true);//bring just the actives books
        }

        //UPDATE
        public bool UpdateCellPhone(Book item)//item is the updated book
        {
            var book =//variable to the book
                contextDB.//using the data base
                Books.//our table who have the books
                FirstOrDefault(x => x.Id == item.Id);//where th old id is like the new id,
            //so, just changing the info, from this book(the informated id)

            if (book == null)//verify if he found a book
                return false;//if negaive, return false
            else
            {
                book.ChangeDate = DateTime.Now;//we update the alteration 
                //date from our book, since we just updated, register this alteration
            }
            contextDB.SaveChanges();//save the canges at the Data Base

            return true;//we return that have been updated
        }

        //DELETE
        public bool RemoveBook(int bookId)
        {
            var bookRemoved = contextDB.Books.FirstOrDefault(x => x.Id == bookId);

            //validations
            if (bookRemoved == null)
                return false;
            bookRemoved.Active = false;

            contextDB.SaveChanges();
            return true;//true as "removing book sucessfully"
        }
        #endregion
    }
}
