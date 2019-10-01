using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ForeachOnList
{
    class Program
    {
        static void Main(string[] args)
        {
            DoubleList();
            Console.ReadKey();
        }

        /// <summary>
        /// Method to convert my number in real to yen
        /// </summary>
        /// <param name="myNumber"></param>My number in reais
        /// <returns></returns>returns the value formated in yen
        private static string DoubleToYenFormat(double myNumber)
        {
            return (myNumber / 0.038).ToString("C2", CultureInfo.CreateSpecificCulture //c2 = 2 casas decimais
                ("ja-JP"));
        }


        /// <summary>
        /// Method to convert my number in real to dollar
        /// </summary>
        /// <param name="myNumber"></param>My number in reais
        /// <returns></returns>returns the value formated in dollar
        private static string DoubleToDollarFormat(double myNumber)
        {

            return (myNumber / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture
                ("en-US")); //without changing the computer configurations to convert the local currency
                            //use this imports and this method, to convert to dollar, for instance
                            //using System.Globalization; at imports
        }


        /// <summary>
        /// Method to convert my number in real to bitcoin
        /// </summary>
        /// <param name="myNumber"></param>My number in reais
        /// <returns></returns>returns the value formated in bitcoin
        private static string DoubleToBitcoinFormat(double myNumber)
        {
            return (myNumber / 41760.84).ToString("C10").Replace("R$", "BTC ");
        }


        /// <summary>
        /// Method to convert my number in real to euro
        /// </summary>
        /// <param name="myNumber"></param>My number in reais
        /// <returns></returns>returns the value formated in euro
        private static string DoubleToEurFormat(double myNumber)
        {
            return (myNumber / 4.52).ToString("C", CultureInfo.CreateSpecificCulture("en-US")).Replace("$", "EUR ");
        }


        /// <summary>
        /// Lis of double numbers
        /// </summary>
        private static void DoubleList()
        {
            Console.WriteLine("\nDouble list:\n");
            var myList = new List<double>();

            myList.Add(3.75);
            myList.Add(4.98);
            myList.Add(2.42);
            myList.Add(0.05);

            //myList.ForEach(i => Console.WriteLine("R$"+i));

            // to reais:(could be dollars..) double to local currency
            myList.ForEach(i => Console.WriteLine(i.ToString("C")));//"c" for currency, local 
            Console.WriteLine("\nDollar:\n");
            //as i wanted to convert the local currency to dollar, i created a methd:
            myList.ForEach(i => Console.WriteLine(DoubleToDollarFormat(i)));

            Console.WriteLine("\nBoth:\n");
            myList.ForEach(i => Console.WriteLine(i.ToString("C") + "  " + DoubleToDollarFormat(i)));

            //Exercises:
            Console.WriteLine("\nExercies\n");
            Console.WriteLine("\nBitcoin\n");
            myList.ForEach(i => Console.WriteLine(DoubleToBitcoinFormat(i)));
            Console.WriteLine("\nYen\n");
            myList.ForEach(i => Console.WriteLine(DoubleToYenFormat(i)));
            Console.WriteLine("\nEur\n");
            myList.ForEach(i => Console.WriteLine(DoubleToEurFormat(i)));

        }


        /// <summary>
        /// Shows a int list
        /// </summary>
        private static void IntListMethod()
        {
            Console.WriteLine("\nInt list:\n");
            var intList = new List<int>();

            intList.Add(17);
            intList.Add(18);
            intList.Add(19);
            intList.Add(20);

            intList.ForEach(i => Console.WriteLine(i));

        }


        /// <summary>
        /// Shows the date list set
        /// </summary>
        private static void DateTimeList()
        {
            Console.WriteLine("\nDate/Time list:\n");
            var myList = new List<DateTime>();

            myList.Add(new DateTime(2019, 9, 17));
            myList.Add(new DateTime(2019, 9, 18));
            myList.Add(new DateTime(2019, 9, 19));
            myList.Add(new DateTime(2019, 9, 20));

            myList.ForEach(i => Console.WriteLine(i
                .ToString("yyyy/MM/dd")));//force to show the american format and not tme, just date
            // .ToLongDateString() - extendended date format
            //("MMM"); to make a "oct" replacing the 09 month

        }


        /// <summary>
        /// Show the string list set
        /// </summary>
        private static void StringList()
        {
            Console.WriteLine("\nString list:\n");
            var myList = new List<string>();

            myList.Add("XIAOMI");
            myList.Add("APPLE");
            myList.Add("SAMSUNG");
            myList.Add("NOKIA");

            myList.ForEach(i => Console.WriteLine(i));
            //Is the same:
            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

        }


    }
}
