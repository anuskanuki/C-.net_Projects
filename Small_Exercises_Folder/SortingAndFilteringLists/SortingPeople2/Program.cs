using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingPeople2.Controller;
using SortingPeople2.Model;
namespace SortingPeople2
{
    class Program
    {
        static void Main(string[] args)
        {
            //now we can list and other functions, cause we loaded our "tool box"
            PeopleController peopleController = new PeopleController();
            ShowIdTitle("Sorted People");
            peopleController.PublicPeopleList.//here we acess our list
                ForEach(i => ShowInfo(i));//the foreach runs the list, and, we print the information

            ShowIdTitle("Sorted by name");
            peopleController.GetSortedPeople().ForEach(i => ShowInfo(i));

            ShowIdTitle("Sorted Birth Day (Descending)");
            peopleController.GetPeopleSortedByDescendingBirth().ForEach(i => ShowInfo(i));

            ShowIdTitle("Sorted by Wallet (+$500)");
            peopleController.GetPeopleSortedByWallet().ForEach(i => ShowInfo(i));

            ShowIdTitle("Sorted by Age (+18)");
            peopleController.GetPeopleSortedByInformedMore().ForEach(i => ShowInfo(i));

            ShowIdTitle("Sorted by Age (-16)");
            peopleController.GetPeopleSortedByLess().ForEach(i => ShowInfo(i));


            Console.ReadKey();
        }
        /// <summary>
        /// Show the initial info for each listing
        /// </summary>
        /// <param name="actionName">Listing identifier</param>
        private static void ShowIdTitle(string actionName)
        {
            Console.WriteLine(string.Format("\n{0,20} ---------------------------------\n", actionName));
        }

        /// <summary>
        /// Method to show at the console, our "people" object formatted
        /// </summary>
        /// <param name="peopleParam"></param>
        private static void ShowInfo(People peopleParam)
        {
            string template = "Id{0,3}  Name {1,10}  Birth Date {2,10}   Wallet {3,8}";//id occupy min 0, max 3 spaces...
            string formattedText = string.Format(template,
                peopleParam.Id,
                peopleParam.Name,
                peopleParam.BirthDate.ToString("dd/MM/yyyy"),
                peopleParam.Wallet.ToString("C"));
            Console.WriteLine(formattedText);
        }

    }
}
