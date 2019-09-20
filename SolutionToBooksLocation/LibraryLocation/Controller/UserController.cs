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
        public List<User> UsersList { get; set; }


        public UserController()
        {
            UsersList = new List<User>();

            UsersList.Add(new User()
            {
                Login = "admin",
                Password = "admin"

            });

            UsersList.Add(new User()
            {
                Login = "nuki",
                Password = "123"
            });
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
            return UsersList.Exists(x => x.Login == users.Login &&
            x.Password == users.Password);
            //if (users.Login == "admin" && users.Password == "admin"
            //    || users.Login == "nuki" && users.Password == "123")
            //    return true;
            //else

            //    return false;
        }

    }


}
