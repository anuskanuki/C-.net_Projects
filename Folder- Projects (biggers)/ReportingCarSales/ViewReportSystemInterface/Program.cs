using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemReporCars.Controller;
using SystemReporCars.Model;

namespace ViewReportSystemInterface
{
    class Program
    {
        static SalesController salesControllerObject = new SalesController();
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------- Information on sales made during 2019 ----------\n");
            salesControllerObject.GetSolds().ForEach(i => ShowInfo(i));
            ShowMenuReport();
            Console.ReadKey();
        }

        private static void ShowMenuReport()
        {
            Console.Clear();
            Console.WriteLine("\n-------- Report Menu --------\n");
            Console.WriteLine("1 - Monthly Report");
            Console.WriteLine("0 - Log off");
            var choosedMenu = int.MinValue;
            while (choosedMenu != 0)
            {
                choosedMenu = int.Parse(Console.ReadLine());
                switch (choosedMenu)
                {
                    case 1:
                        Console.WriteLine("Enter a month to show the report");
                        var choosedMonth = int.Parse(Console.ReadLine());
                        var listChoosedMonth = salesControllerObject.GetSolds(choosedMonth);//we put that in a variable, cause otherway, we're gonna have to use a lot of "object.getsolds(param)", so, instead, create a variable
                        Console.Clear();
                        Console.WriteLine();
                        listChoosedMonth.ForEach(i => ShowInfo(i));
                        var totalMonth = listChoosedMonth.
                            Sum(x => x.PriceCar * x.AmountCars);

                        var periodAvarage = listChoosedMonth.Average(x => x.PriceCar * x.AmountCars);

                        Console.WriteLine($"\nTotal per the {choosedMonth} " +
                            $"month: {totalMonth.ToString("C")}\n\nMonth Average: {periodAvarage.ToString("C")}");
                        Console.ReadKey();
                        break;
                    case 0:
                        Console.ReadKey();
                        break;
                }
            }
        }

        public static void ShowInfo(Sold sold)
        {
            Console.WriteLine(string.Format
                ("Id{0,3}  Car: {1,-27}  Price: {2,-10 }  Amount: {3,3}  Date: {4,12}"
                , sold.IdCar, sold.CarName, sold.PriceCar.ToString("C"),
                sold.AmountCars, sold.Date.ToShortDateString()));
        }

    }
}
