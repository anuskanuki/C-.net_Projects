using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MyLibrary;
namespace InfoAcess
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemMenu();
        }

        private static void SystemMenu()
        {
            Console.WriteLine("\n-----What do you want to do?-----\n");
            Console.WriteLine("ENTER 1 to Area calculator\n ");
            Console.WriteLine("ENTER 2 to Show animation\n ");
            Console.WriteLine("ENTER 3 Out of the system\n ");
            Console.WriteLine("ENTER 4 to show lists\n ");
            var userAnswer = int.Parse(Console.ReadLine());
            switch (userAnswer)
            {
                case 1:
                    AreaCalculator(); SystemMenu();
                    break;
                case 2:
                    RunAnimation.StartAnimation();
                    SystemMenu();
                    break;
                case 3:
                    ShowLists.RunLists();
                    SystemMenu();
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Finishing...");
                    Thread.Sleep(1842);
                    return;
                default:
                    Console.WriteLine("Type a valid number to proceed");
                    break;
            }

        }

        public static void AreaCalculator()
        {
            Console.WriteLine("Enter the square side:");
            var side = double.Parse(Console.ReadLine());
            var calcLibrary = new AreaCalculator();

            Console.WriteLine($"Area =  {calcLibrary.SquareAreaCalculator(side)}");
            Console.ReadKey();
        }

    }
}
