using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01_Welcome
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeText();
            SpaceText();
            FinalizeText();
            Console.ReadKey();
        }

        public static string WelcomeText()
        {
            string text = "\n-----Welcome!-----\n\n :) \n";
            Console.WriteLine(text);
            return text;
        }

        public static string SpaceText()
        {
            string space = "\n\n";
            Console.WriteLine(space);
            return space;
        }

        public static string FinalizeText()
        {
            string text = "Press any key to exit";
            Console.WriteLine(text);
            return text;
        }



    }
}
