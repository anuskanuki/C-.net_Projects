using SortingPeople2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SortingPeople2.Controller
{
    public class PeopleController
    {
        /// <summary>
        /// This list contains the people to do the things with them(ackward)
        /// </summary>
        private List<People> peoplesList { get; set; }
        /// <summary>
        /// Constructor
        /// </summary>
        public PeopleController()
        {
            peoplesList = new List<People>();
            #region listing
            peoplesList.Add(new People() { Id = 1, Name = "Spears  ", BirthDate = DateTime.Parse("07/11/2004"), Wallet = 846.96 });
            peoplesList.Add(new People() { Id = 2, Name = "Swanson  ", BirthDate = DateTime.Parse("20/06/2003"), Wallet = 233.09 });
            peoplesList.Add(new People() { Id = 3, Name = "Gay      ", BirthDate = DateTime.Parse("03/12/2001"), Wallet = 911.92 });
            peoplesList.Add(new People() { Id = 4, Name = "Gregory  ", BirthDate = DateTime.Parse("02/01/2000"), Wallet = 469.01 });
            peoplesList.Add(new People() { Id = 5, Name = "Olson    ", BirthDate = DateTime.Parse("18/07/2001"), Wallet = 261.90 });
            peoplesList.Add(new People() { Id = 6, Name = "Garza    ", BirthDate = DateTime.Parse("01/04/2000"), Wallet = 360.41 });
            peoplesList.Add(new People() { Id = 7, Name = "Sweet    ", BirthDate = DateTime.Parse("12/03/2003"), Wallet = 312.76 });
            peoplesList.Add(new People() { Id = 8, Name = "Cline    ", BirthDate = DateTime.Parse("26/03/2002"), Wallet = 484.51 });
            peoplesList.Add(new People() { Id = 9, Name = "Oliver   ", BirthDate = DateTime.Parse("05/07/2004"), Wallet = 513.76 });
            peoplesList.Add(new People() { Id = 10, Name = "Vang     ", BirthDate = DateTime.Parse("10/07/2000"), Wallet = 271.05 });
            peoplesList.Add(new People() { Id = 11, Name = "Maddox   ", BirthDate = DateTime.Parse("29/05/2004"), Wallet = 783.97 });
            peoplesList.Add(new People() { Id = 12, Name = "Garrett  ", BirthDate = DateTime.Parse("03/06/2006"), Wallet = 154.11 });
            peoplesList.Add(new People() { Id = 13, Name = "Mcintosh ", BirthDate = DateTime.Parse("06/07/2006"), Wallet = 902.80 });
            peoplesList.Add(new People() { Id = 14, Name = "Yang     ", BirthDate = DateTime.Parse("29/04/2005"), Wallet = 550.48 });
            peoplesList.Add(new People() { Id = 15, Name = "Hendricks", BirthDate = DateTime.Parse("05/09/2003"), Wallet = 410.56 });
            peoplesList.Add(new People() { Id = 16, Name = "Cain     ", BirthDate = DateTime.Parse("12/01/2002"), Wallet = 221.13 });
            peoplesList.Add(new People() { Id = 17, Name = "Blackburn", BirthDate = DateTime.Parse("10/05/2000"), Wallet = 135.67 });
            peoplesList.Add(new People() { Id = 18, Name = "Howe     ", BirthDate = DateTime.Parse("27/09/2005"), Wallet = 360.14 });
            peoplesList.Add(new People() { Id = 19, Name = "Pratt    ", BirthDate = DateTime.Parse("18/09/2000"), Wallet = 991.83 });
            peoplesList.Add(new People() { Id = 20, Name = "Sherman  ", BirthDate = DateTime.Parse("20/02/2003"), Wallet = 667.00 });

            #endregion
        }
        /// <summary>
        /// Just returns the list
        /// </summary>
        public List<People> PublicPeopleList
        {
            get { return peoplesList; }
        }

        /// <summary>
        /// This method reurns the peoples list, sorted by ascending format over their names
        /// </summary>
        /// <returns>Returns the value already setted of our list</returns>
        public List<People> GetSortedPeople()
        {
            return peoplesList.OrderBy(x => x.Name).ToList<People>();
        }

        /// <summary>
        /// This methor sort people, descending, by birth date
        /// </summary>
        /// <returns></returns>
        public List<People> GetPeopleSortedByDescendingBirth()
        {
            return peoplesList.OrderByDescending(x => x.BirthDate)
                .ToList<People>();
        }
        /// <summary>
        /// This method returns who have more than 500 in wallet
        /// </summary>
        /// <returns></returns>
        public List<People> GetPeopleSortedByWallet(double value = 500)//if the person wants to change the paremeter when invocating the method, is by choice, but, here we are saying that the default value is 500, so, if we want to be 500, let without paramether
        {
            return peoplesList.FindAll(x => x.Wallet > 500).OrderBy(x => x.Wallet)
                .ToList<People>();
        }

        /// <summary>
        /// this method returns a list with the people who are older than the given paramether
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public List<People> GetPeopleSortedByInformedMore(int age = 18)
        {
            return peoplesList.FindAll(x =>
            (DateTime.Now.Year - x.BirthDate.Year) >= age).OrderBy
                (x => x.BirthDate).ToList<People>();
        }

        /// <summary>
        /// This method returns who have age less than the given paramether
        /// </summary>
        /// <param name="ageToCompare"></param>
        /// <returns></returns>
        public List<People> GetPeopleSortedByLess(int ageToCompare = 16)
        {
            return peoplesList.FindAll(x =>
            (DateTime.Now.Year - x.BirthDate.Year) <= ageToCompare).OrderBy
                (x => x.BirthDate).ToList<People>();
        }

    }
}
