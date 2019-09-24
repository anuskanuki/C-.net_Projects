using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LibraryLocation.Controller;//cause i want to use the user controller class, at athe libraryLocation project
using LibraryLocation.Model;

namespace LibraryInterface
{
    class Program
    {
        static BooksController booksControllerObject = new BooksController();
        static UserController usersControllerObject = new UserController();

        static void Main(string[] args)
        {
            InitializingSys();
        }

        #region SystemInteraction
        public static void InitializingSys()
        {
            Console.Clear();
            Console.WriteLine("\n--------- BOOK LOCATION SYSTEM 1.0 ---------\n");
            while (!DoTheSystemLogin())
            {
                Console.Clear();
                Console.WriteLine("\nInvalid login credentials\n");
            }
            ShowSystemMenu();

        }

        /// <summary>
        /// Shows at the console the avaliable system menu
        /// </summary>
        private static void ShowSystemMenu()
        {
            Console.Clear();
            Console.WriteLine("\n--------- BOOK LOCATION SYSTEM 1.0 ---------\n");
            Console.WriteLine("------- System Menu -------\n");
            Console.WriteLine("1 - Show users");
            Console.WriteLine("2 - Show books");
            Console.WriteLine("3 - Register new book");
            Console.WriteLine("4 - Register new user");
            Console.WriteLine("5 - User log off");
            Console.WriteLine("6 - Delete user");
            Console.WriteLine("7 - Delete book");
            Console.WriteLine("0 - System log out\n");
            var answer = int.Parse(Console.ReadLine());
            UserChoice(answer);
        }

        public static void AskToContinue()
        {
            Console.WriteLine("\n\nSystem Menu\n");
            Console.WriteLine("1 - Show users");
            Console.WriteLine("2 - Show books");
            Console.WriteLine("3 - Register Book");
            Console.WriteLine("0 - Log out\n");
            var answer = int.Parse(Console.ReadLine());
            UserChoice(answer);
        }

        private static void UserChoice(int answer)
        {
            switch (answer)
            {
                case 1:
                    ShowUsers();
                    break;
                case 2:
                    ShowBooks();
                    break;
                case 3:
                    AddBook();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("\nLog out...");
                    Thread.Sleep(1700);
                    InitializingSys();
                    break;
                case 4:
                    AddNewUser();
                    Console.Clear();
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("\nLog off...");
                    Thread.Sleep(1700);
                    Console.Clear();
                    InitializingSys();
                    while (!DoTheSystemLogin())
                    {
                        Console.WriteLine("Invalid credentials");
                    }
                    break;
                case 6:
                    Console.Clear();
                    DeleteUser();
                    break;
                case 7:
                    Console.Clear();
                    DeleteBook();
                    break;
            }
        }

        /// <summary>
        /// This method do the complet proceedures from login inside the system, as
        /// for ligin and password at the console, just like the respectives validations that
        /// he needs to sign in
        /// </summary>
        /// <returns>Return true when the entered login and password are correct</returns>
        private static bool DoTheSystemLogin()
        {
            Console.WriteLine("Enter your login and your password to acess:");

            Console.Write("\nLogin:  ");
            var userLogin = Console.ReadLine();

            Console.Write("\nPassword:  ");
            var userPassword = Console.ReadLine();

            //click and press f9, is to start a breakpoint, so, 
            //when we execute the project, will be started on the
            //breakpoint, so we don't have to pass at f11 until the part that we want to

            User user = new User();
            user.Login = userLogin;
            user.Password = userPassword;
            return usersControllerObject.SystemLogin(user);
            //or, do just:
            //return userController.SystemLogin(new User()
            //{
            //    Login = userLogin,
            //    Password = userPassword
            //});
        }

        #endregion

        #region ShowUsers/Books
        public static void ShowBooks()
        {
            Console.Clear();
            Console.WriteLine("\nBooks list: ");
            booksControllerObject.ReturnsBookList().ForEach(i => Console.WriteLine($"\nID {i.Id}  Book name: {i.Name}"));
            AskToContinue();
        }

        public static void ShowUsers()
        {
            Console.Clear();
            Console.WriteLine("\nUsers list: ");
            usersControllerObject.ReturnsUserList().ForEach(i => Console.WriteLine($"\nID{i.Id}  User login: {i.Login}"));
            AskToContinue();
        }

        #endregion

        #region UserDelete/Add

        /// <summary>
        /// Method to delete the given user, by ID
        /// </summary>
        private static void DeleteUser()
        {
            Console.WriteLine("DELETE USER BY ID");
            Console.WriteLine("Choose the user to be deleted:");
            //ShowUsers();
            usersControllerObject.ReturnsUserList().ForEach(i => Console.WriteLine($"\nID{i.Id}  User login: {i.Login}"));
            Console.WriteLine("Enter the selected ID:");
            var idUserDelete = int.Parse(Console.ReadLine());
            usersControllerObject.DeleteUserByID(idUserDelete);
            Console.WriteLine("\n\nSuccessfully deleted user!\n");
            Thread.Sleep(1700);
            ShowSystemMenu();
        }

        /// <summary>
        /// Method to add a new user to the system.
        /// </summary>
        private static void AddNewUser()
        {
            Console.Clear();
            Console.WriteLine("---- Register new user ----\n");
            Console.Write("Enter a Login: ");
            var loginName = Console.ReadLine();
            Console.Write("\nChoose a password:");
            var passwordUser = Console.ReadLine();
            usersControllerObject.AddUser(new User()
            {
                Login = loginName,

                Password = passwordUser


            });
            Console.WriteLine("\n\nSuccessfully registered user!\n");
            Thread.Sleep(1700);
            ShowSystemMenu();
        }

        #endregion

        #region BookDelete/Add

        /// <summary>
        /// Method to delete the given book, by ID
        /// </summary>
        private static void DeleteBook()
        {
            Console.WriteLine("DELETE BOOK BY ID");
            Console.WriteLine("Choose the book to be deleted:");
            //ShowBooks();
            booksControllerObject.ReturnsBookList().ForEach(i => Console.WriteLine($"\nID{i.Id}  Book Name: {i.Name}"));
            Console.WriteLine("\nEnter the selected ID:");
            var idBookToRemove = int.Parse(Console.ReadLine());
            booksControllerObject.DeleteBookByID(idBookToRemove);
            Console.WriteLine("\n\nSuccessfully deleted book!\n");
            Thread.Sleep(1700);
            ShowSystemMenu();
        }

        /// <summary>
        /// Method to add a book in the books list, a new book registration
        /// </summary>
        private static void AddBook()
        {
            Console.Clear();
            Console.WriteLine("\n---Register book in the system---\n\n");
            Console.Write("Enter the book name: ");
            var bookName = Console.ReadLine();
            booksControllerObject.AddBook(new Book()
            {
                Name = bookName
            });
            Console.WriteLine("\n\nSuccessfully registered book!\n");
            Thread.Sleep(1700);
            ShowSystemMenu();
        }

        #endregion

    }
}
