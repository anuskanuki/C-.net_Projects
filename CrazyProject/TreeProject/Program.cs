using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SquareAreaCalculation(height, width);
            Console.ReadKey();
        }

        public static void Tree()
        {
            Console.WriteLine("    *");
            Console.WriteLine("   **");
            Console.WriteLine("  ****");
            Console.WriteLine(" ******");
            Console.WriteLine("********");
        }


        public static double UserAsk()
        {
            Console.WriteLine("---Square Area Calculator---");
            Console.WriteLine("\nType the square height:\n ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("\nType the square width:\n ");
            width = double.Parse(Console.ReadLine());
            return height, width;

        }
            public static double SquareAreaCalculation(double height, double width)
        {

            Console.WriteLine("---Square Area Calculator---");
            Console.WriteLine("\nType the square height:\n ");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("\nType the square width:\n ");
            width = double.Parse(Console.ReadLine());

            double squareArea = 0.0;
            squareArea = height * width;

            return squareArea;
        }

    }
}
