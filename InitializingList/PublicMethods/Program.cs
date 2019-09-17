using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicMethods
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProcessingConvert();
        }

        public static void ProcessingConvert()
        {
            Console.WriteLine("---Currency conversor system---");
            Console.WriteLine("\nEnter a value to be converted:\n");
            var valueToBeConverted = double.Parse(Console.ReadLine());

            // List<string> currencysList = new List<string>() { "DOLLAR", "EUR", "YEN", "BITCOIN" };

            Console.WriteLine("\nEnter a currency to convert:\n");
            Console.WriteLine("DOLLAR\nEUR\nYEN\nBITCOIN\n");
            var currencyTarget = Console.ReadLine().ToUpper();

            //if (!currencysList.Contains(currencyTarget))
            //{
            //    Console.WriteLine("Invalid currency");
            //    Console.ReadKey();
            //    Console.Clear();
            //    ProcessingConvert();
            //}
            Console.WriteLine("\nConverted currency:");
            ConvertCurrency(valueToBeConverted, currencyTarget);
            Console.ReadKey();

        }

        /// <summary>
        /// Method to convert , assuming that the local currency is reais
        /// //reais to a target specify. to convert type the targets:
        /// - "EURO"
        /// - "YEN"
        /// - "BTC"
        /// - "DOLLAR"
        /// </summary>
        /// <param name="myCurrency"></param>My local currency
        /// <param name="currencyChain"></param>target who the currency is gonna be converted to
        public static void ConvertCurrency(double myCurrency, string currencyChain)
        {
            switch (currencyChain)
            {
                case "DOLLAR":
                    Console.WriteLine(DoubleToDollarFormat(myCurrency));
                    break;

                case "EUR":
                    Console.WriteLine(DoubleToEurFormat(myCurrency));
                    break;

                case "YEN":
                    Console.WriteLine(DoubleToYenFormat(myCurrency));
                    break;

                case "BTC":
                    Console.WriteLine(DoubleToBitcoinFormat(myCurrency));
                    break;

                default:
                    Console.WriteLine("Invalid information");
                    break;
            }

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
                ("en-US"));
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

    }
}
