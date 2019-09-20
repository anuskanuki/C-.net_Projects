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
        static BooksController books = new BooksController();
        static UserController users = new UserController();
        static void Main(string[] args)
        {
            //Console.WriteLine("\n--------- BOOK LOCATION SYSTEM 1.0 ---------\n");
            //while (!DoTheSystemLogin())
            //{
            //    Console.Clear();
            //    Console.WriteLine("\nInvalid login credentials\n");
            //}
            //ShowSystemMenu();
            InitializingSys();
        }

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

        public static void ShowUsers()
        {
            Console.Clear();
            Console.WriteLine("\nUsers list:");
            users.UsersList.ForEach(i => Console.WriteLine($"\nUser login: {i.Login}"));
            AskToContinue();
        }
        public static void AskToContinue()
        {
            Console.WriteLine("\n\nSystem Menu\n");
            Console.WriteLine("1 - Show users\n");
            Console.WriteLine("2 - Show books\n");
            Console.WriteLine("3 - Register Book\n");
            Console.WriteLine("0 - Log out\n");
            var answer = int.Parse(Console.ReadLine());
            UserChoice(answer);
        }

        public static void ShowBooks()
        {
            Console.Clear();
            Console.WriteLine("\nBooks list:");

            books.Books.ForEach(i => Console.WriteLine($"\nBook name: {i.Name}"));

            AskToContinue();

        }

        /// <summary>
        /// Shows at the console the avaliable system menu
        /// </summary>
        private static void ShowSystemMenu()
        {
            Console.WriteLine("\n--------- BOOK LOCATION SYSTEM 1.0 ---------\n");
            Console.WriteLine("System Menu\n");
            Console.WriteLine("1 - Show users\n");
            Console.WriteLine("2 - Show books\n");
            Console.WriteLine("3 - Register Book\n");
            Console.WriteLine("4 - User log off\n");
            Console.WriteLine("0 - System log out\n");
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
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("\nLog out...");
                    Thread.Sleep(1700);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("\nLog off...");
                    Thread.Sleep(1700);
                    Console.Clear();
                    while (!DoTheSystemLogin())
                    {
                        Console.WriteLine("Invalid credentials");
                    }
                    //InitializingSys();
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

            UserController userController = new UserController();//instance

            //click and press f9, is to start a breakpoint, so, 
            //when we execute the project, will be started on the
            //breakpoint, so we don't have to pass at f11 until the part that we want to

            User user = new User();
            user.Login = userLogin;
            user.Password = userPassword;
            return userController.SystemLogin(user);
            //or, do just:
            //return userController.SystemLogin(new User()
            //{
            //    Login = userLogin,
            //    Password = userPassword
            //});
        }


    }
}
