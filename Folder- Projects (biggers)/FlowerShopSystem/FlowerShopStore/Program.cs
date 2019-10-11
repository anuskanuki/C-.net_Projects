using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Model;
using FlowerShop.Controller;

namespace FlowerShopStore
{
    class Program
    {
        static ReportController controllerFlowers = new ReportController();
        static void Main(string[] args)
        {
            ChoiceSwitch();
        }

        public static int MenuStart()
        {
            Console.Clear();
            Console.WriteLine("----- WELCOME TO THE FLOWERS SHOP -----\n\n");
            Console.WriteLine("(1).Register new flower\n");
            Console.WriteLine("(2).Show availiable flowers\n");
            Console.WriteLine("(3).Show each flower amount by descending\n");
            Console.WriteLine("(4).Show total flowers amount\n");
            Console.Write("\nEnter the choosed option: ");
            var choice = int.Parse(Console.ReadLine());
            return choice;
        }

        public static void ChoiceSwitch()
        {
            switch (MenuStart())
            {
                case 1:
                    AddFlower();
                    break;
                case 2:
                    ShowFlowers();
                    break;
                case 3:
                    SortingByAmount();
                    break;
                case 4:
                    ShowAmount();
                    break;
                default:
                    Console.WriteLine("Type a valid option");
                    break;
            }
        }

        public static void ShowFlowers()
        {
            controllerFlowers.GetFlowers().ToList().ForEach(x =>
            Console.WriteLine($"Flower: {x.FlowerName}  Amount: {x.FlowerAmount}"));
            BackToTheMenu();
        }

        public static void SortingByAmount()
        {
            controllerFlowers.GetFlowers().
                OrderByDescending(p => p.FlowerAmount).ToList().ForEach(x =>
            Console.WriteLine($"Flower: {x.FlowerName}  Amount: {x.FlowerAmount}"));
            BackToTheMenu();
        }

        public static void ShowAmount()
        {
            var total = controllerFlowers.GetFlowers().
                Sum(x => x.FlowerAmount);
            Console.WriteLine
                ($"\nTotal flowers at the flower shop: {total}");
            BackToTheMenu();
        }

        public static void BackToTheMenu()
        {
            Console.WriteLine("\n(ENTER). Back to the MENU");
            Console.ReadKey();
            MenuStart();
        }

        public static void AddFlower()
        {
            Console.Clear();
            Console.WriteLine("----- REGISTER NEW FLOWER -----\n\n");
            Console.Write("Flower name: ");
            var name = Console.ReadLine();
            Console.Write("Amount: ");
            var amount = int.Parse(Console.ReadLine());
            //validating 
            if (name.Equals(null))
                throw new ArgumentException("Invalid flower name");

            if (amount.Equals(null) || amount < 0)
                //{
                throw new ArgumentException("Invalid flower amount");
            // Console.WriteLine("Invalid flower amount");
            //return false;
            //}

            controllerFlowers.InsertFlower(new Flower()
            {
                FlowerName = name,
                FlowerAmount = amount
            });
            Console.WriteLine("\n\nSucessfully registered flower!");
            BackToTheMenu();
        }


    }
}
