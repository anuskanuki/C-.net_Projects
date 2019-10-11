using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CarRegistration.Model;
using System.Text.RegularExpressions;

namespace CarRegistration
{
    class Program
    {
        static List<Car> carsList = new List<Car>();
        static int countCars = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("---- Car Registration System ----");
            AskRegistration();
        }

        public static void RegisterCar()
        {
            Console.WriteLine("Add new car:\n");

            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Model: ");
            string model = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Value: ");
            double value = double.Parse(Console.ReadLine());

                carsList.Add(new Car
                {
                    Brand = brand,
                    Model = model,
                    Year = year,
                    Value = value,
                    CarLicensePlate = VerifyCarPlate(),
                });
                countCars++;
            
            ShowAddedCar();
            AskToContinue();
        }

        public static void ShowAddedCar()
        {
            carsList.ForEach(i => Console.WriteLine
              ($"Brand: {i.Brand}\nModel: {i.Model}\nYear: {i.Year}" +
              $"\nValue: {i.Value}\nCar License Plate: {i.CarLicensePlate}\n\n"));
        }

        public static string VerifyCarPlate()
        {
            var comeBack = string.Empty;
            Console.Write("Car License Plate: ");
            string carLicensePlate = Console.ReadLine();
            //VerificationsRegex reg = new VerificationsRegex();
            //return reg.PlateCarVerify(input);
            if (VerificationsRegex.PlateCarVerify(carLicensePlate))
                comeBack = VerifyCarPlate();
            else
                comeBack = carLicensePlate;

            return comeBack;
        }

        public static void ShowCars()
        {
            if (countCars != 0)
            {
                Console.Clear();
                Console.WriteLine("\n---- Cars list ----\n\n");

                carsList.ForEach(i => Console.WriteLine(i.ToString()));
            }
            AskToContinue();
        }

        public static void AskToContinue()
        {
            Console.WriteLine("\nDo you want to add another car?\n");
            Console.WriteLine
                ("TYPE 1 - ADD NEW CAR\n" +
                "TYPE 2 - LOG OUT\n" +
                "TYPE 3 - SHOW CARS LIST\n\n");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    RegisterCar();
                    break;
                case 2:
                    Console.WriteLine("Shutting down...");
                    Thread.Sleep(1800);
                    break;
                case 3:
                    ShowCars();
                    break;

            }
        }

        public static void AskRegistration()
        {
            Console.WriteLine("\nDo you want to registrate a car?\n");
            Console.WriteLine("TYPE 1 - YES\nTYPE 2 - NO\n");
            var answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case (1):
                    RegisterCar();
                    break;

                case (2):
                    Console.WriteLine("Shutting down...");
                    Thread.Sleep(1800);
                    break;
            }
        }

    }
}
