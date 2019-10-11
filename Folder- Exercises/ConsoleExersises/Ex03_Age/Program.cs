using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            int age = 0;



            name = AskName();
            age = AskAge(name);

            Console.ReadKey();
        }

        private static int AskAge(string name)
        {
            Console.WriteLine("\n\nHow old are you?\n");
            int userAge = int.Parse(Console.ReadLine());
            if (userAge >= 21)
            {
                Console.WriteLine($"\nCongratulations {name}, you are already in adulthood!\n");
            }
            else
            {
                Console.WriteLine($"\nCalm down {name}, all in time, soon you will be of age and begin in adulthood");
            }
            return userAge;
        }


        private static string AskName()
        {
            Console.WriteLine("\n\nWhat is your name?\n");
            return Console.ReadLine();
        }


    }
}
