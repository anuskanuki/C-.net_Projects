using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSaleReports.Model;
using CarSaleReports.Controller;

namespace ReportingSystem
{
    public class Program
    {

        public static CarsController CarsControllerObject = new CarsController();
        static void Main(string[] args)
        {
            InitializingSystem();
            Console.ReadKey();
        }

        public static void InitializingSystem()
        {
            //Console.Clear();
            ShowSystemMenu();
        }

        public static void ShowSystemMenu()
        {
            Console.WriteLine("\n--------- CARS SALE SYSTEM 1.0 ---------\n");
            Console.WriteLine("------- System Menu -------\n");
            Console.WriteLine("1 - Show cars list");
            Console.WriteLine("2 - Show Report by Month");
            var answer = int.Parse(Console.ReadLine());
            UserChoice(answer);
        }

        public static void ShowReportMonth()
        {
            Console.Clear();
            Console.WriteLine("\n-------------- Report by Month --------------\n");
            Console.Write("Type a month\n");
            var answer = int.Parse(Console.ReadLine());
            Console.WriteLine
                (CarsControllerObject.ReturnsCarsList().Aggregate


                ((name1, name2) => name1 + "\r\n" + name2));

        }

        //List<Sale> saleList = new List<Sale>()
        //    {
        //        new Sale(){Product="Iphone 8 plus - 256GB SpaceGray",Amount=8,Value=4000},
        //        new Sale(){Product="Iphone 6s - 32GB Silver",Amount=5,Value=3000},
        //        new Sale(){Product="SONY/SAMSUNG/MOTOROLA trash",Amount=1,Value=1000}
        //    };
        //Console.WriteLine("Products sold average - This month");
        //    Console.WriteLine(saleList.Average(x => x.Amount));
        //    Console.WriteLine("Average sold (R$) - This month ");
        //    Console.WriteLine(saleList.Average(x => (x.Amount* x.Value)));
        //    Console.ReadKey();

        public static void UserChoice(int answer)
        {
            switch (answer)
            {
                case 1:
                    ShowCarsList();
                    break;
                case 2:
                    ShowReportMonth();
                    break;
            }


        }
        public static void ShowCarsList()
        {
            Console.Clear();
            Console.WriteLine("\n-------------- Cars list: --------------\n");
            CarsControllerObject.ReturnsCarsList().ForEach(i => Console.WriteLine
            ($"\nID {i.IdCar}  Car name: {i.CarName} " +
            $"Price: {i.CarPrice} Cars Amount: {i.AmountCar} Date: {i.DateCar.ToShortDateString()}"));
            ShowSystemMenu();
        }






    }
}
