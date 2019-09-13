using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02_Name
{
    class Program
    {
        static void Main(string[] args)
        {

            WelcomeText();
            string name = AskName();
            WelcomeWithName(name);
            Console.ReadKey();


        }

        private static string AskName()
        {
            Console.WriteLine("\n\nWhat is your full name?\n");
            return Console.ReadLine();
        }


        public static string WelcomeWithName(string name)
        {
            string text = $"\n\n-----Welcome {name}!-----\n\n :) \n";
            Console.WriteLine(text);
            return text;
        }


        public static string WelcomeText()
        {
            string text = "\n-----Welcome!-----\n\n";
            Console.WriteLine(text);
            return text;
        }



    }
}
