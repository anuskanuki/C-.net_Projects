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


        }



        public static string WelcomeWithName()
        {
            string text = $"\n-----Welcome {name}!-----\n\n :) \n";
            Console.WriteLine(text);
            return text;
        }


        public static string WelcomeText()
        {
            string text = "\n-----Welcome!-----\n\n :) \n";
            Console.WriteLine(text);
            return text;
        }



    }
}
