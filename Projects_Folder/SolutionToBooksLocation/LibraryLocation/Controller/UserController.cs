using LibraryLocation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLocation.Controller
{
    /// <summary>
    /// This class contains user methods of the system
    /// </summary>
    public class UserController
    {
        BooksContextDB contextDB = new BooksContextDB();


        /// <summary>
        /// Method to login on the system
        /// To do the pattern login use:
        /// -Login: Admin
        /// -Password: Admin
        /// </summary>
        /// <param name="User">param>Give an object named user as parameters</
        /// <returns>Returns true when exists user with the specified login and password</returns>
        public bool SystemLogin(User users)
        {
            return GetUsers().ToList<User>().Exists(x => x.Login == users.Login &&
             x.Password == users.Password);
        }

        #region CRUD
        //CRUD
        //CREATE
        public bool AddUser(User itemUser)
        {
            //validations
            if (string.IsNullOrWhiteSpace(itemUser.Login))
                return false;

            contextDB.Users.Add(itemUser);//insert into users list
            contextDB.SaveChanges();
            return true;

            //BEFORE THE DATA BASE, USED TO DO:
            //itemUser.CreationDate = DateTime.Now;
            //itemUser.Id = DataBaseContext.IdCountUsers++;
            //DataBaseContext.UsersList.Add(itemUser);
        }

        //READ
        public IQueryable<User> GetUsers()
        {
            return contextDB.Users.Where(x => x.Active == true);//bring just the actives users
            //BEFORE WE USED TO DO:
            ////returns just the activated users
            //return DataBaseContext.UsersList.Where(x => x.Active).ToList<User>();
        }

        //UPDATE
        public bool UpdateUser(User itemUser)//item is the updated user
        {
            var user = contextDB.Users.FirstOrDefault(x => x.Id == itemUser.Id);

            if (user == null)//verify if he found a user
                return false;//if negaive, return false
            else
            {
                user.ChangeDate = DateTime.Now;//we update the alteration 
                //date from our user, since we just updated, register this alteration
            }
            contextDB.SaveChanges();//save the canges at the Data Base

            return true;//we return that have been updated
            //(Before we didn't have an update method)
        }

        //DELETE
        public bool DeleteUser(int userId)
        {

            var userRemoved = contextDB.Users.FirstOrDefault(x => x.Id == userId);

            //validations
            if (userRemoved == null)
                return false;
            userRemoved.Active = false;

            contextDB.SaveChanges();
            return true;//true as "removing user sucessfully"

            //BEFORE WE USED TO DO:
            ////first or default returns null in case he doesn't find the register
            //var userHere = DataBaseContext.UsersList.FirstOrDefault(x => x.Id == userId);
            //if (userHere != null) //exception treatment
            //    userHere.Active = false;
            ////instead of just:
            ////UsersList.FirstOrDefault(x => x.Id == userIDNumber).Active = false;
        }
        #endregion

    }
}
