using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLocation.Model
{
    public class LocationContext
    {
        //this propriety stores the books id's added to the system
        public int IdCountBooks { get; set; } = 1001;
        public int IdCountUsers { get; set; } = 1001;

        public List<Book> BooksList { get; set; }
        public List<User> UsersList { get; set; }


        /// <summary>
        /// Constructor-> prepares the location context class 
        /// </summary>
        public LocationContext()
        {
            BooksList = new List<Book>();//creating a books list in memory
            UsersList = new List<User>();//creating a new users list in memory

            UsersList.Add(new User() { Id = IdCountUsers++, Login = "nuki", Password = "123" });
            UsersList.Add(new User() { Id = IdCountUsers++, Login = "admin", Password = "123" });

            BooksList.Add(new Book() { Id = IdCountBooks++, Name = "Hihi Book" });
            BooksList.Add(new Book() { Id = IdCountBooks++, Name = "Hot dog" });
        }


    }
}
