using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BikesRegistration.Model;
using BikesRegistration.Controller;

namespace BikesRegisters
{

    class Program
    {
        static BikeController controllerBikes = new BikeController();
        static void Main(string[] args)
        {
            ChoiceSwitch();
        }

        public static int MenuStart()
        {
            Console.Clear();
            Console.WriteLine("----- WELCOME TO THE BIKES SYSTEM -----\n\n");
            Console.WriteLine("(1).Register new bike\n");
            Console.WriteLine("(2).Show availiable bikes\n");
            Console.WriteLine("(3).Show bike price by descending\n");
            Console.Write("\nEnter the choosed option: ");
            var choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public static void ChoiceSwitch()
        {
            switch (MenuStart())
            {
                case 1:
                    AddBike();
                    break;
                case 2:
                    ShowBikes();
                    break;
                case 3:
                    SortingByPrice();
                    break;
                default:
                    Console.WriteLine("Type a valid option");
                    break;
            }
        }

        public static void ShowBikes()
        {
            controllerBikes.GetBikes().ToList().ForEach(x =>
            Console.WriteLine
            ($"Model: {x.Model}  Brand: {x.Brand}  Price: {x.Price}"));
            BackToTheMenu();
        }

        public static void SortingByPrice()
        {
            controllerBikes.GetBikes().
                OrderByDescending
                (p => p.Price).ToList().ForEach(x =>
            Console.WriteLine
            ($"Brand: {x.Brand}  Model: {x.Model}"));

            var sm = controllerBikes.GetBikes().
                Sum(x => x.Price);

            Console.WriteLine($"\n\nPrices Sum: {sm}");
            ExportingBikes();
            BackToTheMenu();
        }


        public static void ExportingBikes()
        {
            Console.WriteLine("\n\nDo you want to export those informations?");
            Console.Write("(1). YES\n(2).NO  \n");
            var exp = int.Parse(Console.ReadLine());
            switch (exp)
            {
                case 1:
                    break;
                case 2:
                    BackToTheMenu();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    BackToTheMenu();
                    break;
            }
        }

        public static void BackToTheMenu()
        {
            Console.WriteLine("\n(ENTER). Back to the MENU");
            Console.ReadKey();
            MenuStart();
        }

        public static void AddBike()
        {
            Console.Clear();
            Console.WriteLine("----- REGISTER NEW BIKE -----\n\n");
            Console.Write("Brand: ");
            var brand = Console.ReadLine();
            Console.Write("Model: ");
            var model = Console.ReadLine();
            Console.Write("Price: ");
            var price = double.Parse(Console.ReadLine());


            //validating 
            if (brand.Equals(null))
            {
                Console.WriteLine("Invalid  brand");
                BackToTheMenu();
            }
            if (model.Equals(null))
            {
                Console.WriteLine("Invalid  model");
                BackToTheMenu();
            }
            if (price.Equals(null) || price < 0)
            {
                Console.WriteLine("Invalid price");
                BackToTheMenu();
            }
            controllerBikes.AddBike(new Bike()
            {
                Brand = brand,
                Model = model,
                Price = price
            });
            Console.WriteLine("\n\nSucessfully registered bike!");
            BackToTheMenu();
        }

    }
}
