using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SortingPeople
{
    class Program
    {
        static void Main(string[] args)
        {
            var peoplesList = new List<People>();
            #region listing
            //Add by constructor method:
            peoplesList.Add(new People(1, "Spears", DateTime.Parse("07/11/2004"), 846.96));
            peoplesList.Add(new People(2, "Swanson", DateTime.Parse("20/06/2003"), 233.09));
            peoplesList.Add(new People(3, "Gary", DateTime.Parse("03/12/2001"), 911.92));
            peoplesList.Add(new People(4, "Gregory", DateTime.Parse("02/01/2000"), 469.01));
            peoplesList.Add(new People(5, "Olson", DateTime.Parse("18/07/2001"), 261.90));
            peoplesList.Add(new People(6, "Garza", DateTime.Parse("01/04/2000"), 360.41));
            peoplesList.Add(new People(7, "Sweet", DateTime.Parse("12/03/2003"), 312.76));
            peoplesList.Add(new People(8, "Cline", DateTime.Parse("26/03/2002"), 484.51));
            peoplesList.Add(new People(9, "Oliver", DateTime.Parse("05/07/2004"), 513.76));
            peoplesList.Add(new People(10, "Vang", DateTime.Parse("10/07/2000"), 271.05));
            peoplesList.Add(new People(11, "Maddox", DateTime.Parse("29/05/2004"), 783.97));
            peoplesList.Add(new People(12, "Garrett", DateTime.Parse("03/06/2006"), 154.11));
            peoplesList.Add(new People(13, "Mcintosh", DateTime.Parse("06/07/2006"), 902.80));
            peoplesList.Add(new People(14, "Yang", DateTime.Parse("29/04/2005"), 550.48));
            peoplesList.Add(new People(15, "Hendricks", DateTime.Parse("05/09/2003"), 410.56));
            peoplesList.Add(new People(16, "Cain", DateTime.Parse("12/01/2002"), 221.13));
            peoplesList.Add(new People(17, "Blackburn", DateTime.Parse("10/05/2000"), 135.67));
            peoplesList.Add(new People(18, "Howe", DateTime.Parse("27/09/2005"), 360.14));
            peoplesList.Add(new People(19, "Pratt", DateTime.Parse("18/09/2000"), 991.83));
            peoplesList.Add(new People(20, "Sherman", DateTime.Parse("20/02/2003"), 667.00));
            #endregion
            #region Name
            Console.WriteLine("------------ Sorting people by name ------------\n");
            peoplesList.OrderBy(x => x.Name).ToList<People>().
                ForEach(i => Console.WriteLine
                ($"Id {i.Id} . Name: {i.Name} . Wallet: {i.Wallet} . Birth Date: {i.BirthDate}"));
            #endregion
            #region BirthDate
            Console.WriteLine("\n\n---------- Sorting people by descending birth date ----------\n");
            peoplesList.OrderByDescending(x => x.BirthDate).ToList<People>().
                ForEach(i => Console.WriteLine
               ($"Id {i.Id} . Name: {i.Name} . Wallet: {i.Wallet} . Birth Date: {i.BirthDate.ToString("dd/MM/yyy")}"));
            #endregion
            #region Wallet+500Filter
            Console.WriteLine("\n------------ Sorting people by WALLET (+500,00) ------------\n");
            var walletFilter = peoplesList.Where(x => x.Wallet > 500).OrderBy(x => x.Name);
            walletFilter.ToList<People>().
                ForEach(i =>
                Console.WriteLine($"Id {i.Id} . Name: {i.Name} . Wallet: " +
                $"{i.Wallet} . Birth Date: {i.BirthDate.ToString("dd/MM/yyy")}"));
            #endregion
            #region ByAge18+
            Console.WriteLine("\n------------ Sorting people by Age (+18y) ------------\n");
            foreach (var item in peoplesList)
            {
                int age = DateTime.Now.Year - item.BirthDate.Year;
                if (age > 18)
                    Console.WriteLine($"Id {item.Id} . Name: {item.Name} . Wallet: " +
                $"{item.Wallet} . Birth Date: {item.BirthDate.ToString("dd/MM/yyy")}");
            }
            #endregion
            #region ByAge16-
            Console.WriteLine("\n------------ Sorting people by Age (-16y) ------------\n");
            foreach (var item in peoplesList)
            {
                int age = DateTime.Now.Year - item.BirthDate.Year;
                if (age < 16)
                    Console.WriteLine($"Id {item.Id} . Name: {item.Name} . Wallet: " +
                        $"{item.Wallet} . Birth Date: {item.BirthDate.ToString("dd/MM/yyy")}");
            }
            #endregion

            Console.ReadKey();

        }


    }
}
