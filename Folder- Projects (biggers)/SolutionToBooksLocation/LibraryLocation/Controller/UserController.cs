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
        SystemContextDB contextDB = new SystemContextDB();

        public UserController()
        {
            var defaultUser = contextDB.Users.FirstOrDefault(x =>
            x.Login == "admin" && x.Password == "admin");

            if (defaultUser == null)
                contextDB.Users.Add(new User()
                {
                    Login = "admin",
                    Password = "admin"
                });
            contextDB.SaveChanges();
        }

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
            bool teste = GetUsers().ToList().Exists(x => x.Login == users.Login &&
             x.Password == users.Password);
            return teste;
        }

        #region CRUD
        //CRUD
        //CREATE
        /// <summary>
        /// This method validates and insert registers at the system
        /// </summary>
        /// <param name="itemUser">the new user</param>
        /// <returns>Returns true to a valid user</returns>
        public bool AddUser(User itemUser)
        {
            //validations
            if (string.IsNullOrWhiteSpace(itemUser.Login))//if it doesn't have something (null)
                return false;//"Couldn't add the user"

            contextDB.Users.Add(itemUser);//insert into users list:
            //"contextDB" is th instance from our "SystemContextDB", who own just the tables created in DataBase
            //".Users", because, we're saying that, on the "contextDB", our dataBase,
            //we have a table named "Users", and:
            //".Add" add at the Users table the param item "itemUser", witch is a variable, could have different names
            contextDB.SaveChanges();//As we're messing with the DataBase, always save the changes
            return true;//"User added"

            //BEFORE THE DATA BASE, USED TO DO:
            //itemUser.CreationDate = DateTime.Now;
            //itemUser.Id = DataBaseContext.IdCountUsers++;
            //DataBaseContext.UsersList.Add(itemUser);
        }

        //READ
        /// <summary>
        /// This methos red the actives users list 
        /// </summary>
        /// <returns>Returns the filtered users by actives users</returns>
        public IQueryable<User> GetUsers()
        {
            return contextDB.Users.Where(x => x.Active == true);//bring just the actives users
            //BEFORE WE USED TO DO:
            ////returns just the activated users
            //return DataBaseContext.UsersList.Where(x => x.Active).ToList<User>();
        }

        //UPDATE
        /// <summary>
        /// This method updates a valid user register from the system
        /// </summary>
        /// <param name="itemUser">The user to be updated</param>
        /// <returns>Returns true if the item exists</returns>
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
        /// <summary>
        /// This method is to just disable an user from the system
        /// </summary>
        /// <param name="userId">Informed ID wanted to disable</param>
        /// <returns>Return true in sucess case</returns>
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
