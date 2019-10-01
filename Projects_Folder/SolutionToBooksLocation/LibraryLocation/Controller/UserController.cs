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

        private LocationContext DataBaseContext = new LocationContext();

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
            return ReturnsUserList().Exists(x => x.Login == users.Login &&
            x.Password == users.Password);
        }

        public List<User> ReturnsUserList()
        {
            //returns just the activated users
            return DataBaseContext.UsersList.Where(x => x.Active).ToList<User>();
        }

        #region Add/Delete User
        /// <summary>
        /// Method to add a new user at the systems
        /// </summary>
        /// <param name="userParam">New user to be added at the list</param>
        public void AddUser(User userParam)
        {
            userParam.CreationDate = DateTime.Now;
            userParam.Id = DataBaseContext.IdCountUsers++;
            DataBaseContext.UsersList.Add(userParam);
        }
        /// <summary>
        /// Method to disable the user register at our ist
        /// </summary>
        /// <param name="userIDNumber">parameter who identf. the user to be disabled</param>
        public void DeleteUserByID(int userIDNumber)
        {
            //first or default returns null in case he doesn't find the register
            var userHere = DataBaseContext.UsersList.FirstOrDefault(x => x.Id == userIDNumber);
            if (userHere != null) //exception treatment
                userHere.Active = false;
            //instead of just:
            //UsersList.FirstOrDefault(x => x.Id == userIDNumber).Active = false;
        }
        #endregion

    }
}
