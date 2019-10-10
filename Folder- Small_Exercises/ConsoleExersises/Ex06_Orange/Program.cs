using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex06_Orange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome!\n\nPlease, enter a text or a message:\n");
            var textContent = Console.ReadLine();

            OrangeReplace(textContent);
            Console.ReadKey();
        }

        private static string OrangeReplace(string userText)
        {
            Console.WriteLine("\nWatch the bananas turning into oranges:\n");
            string newText = string.Empty;

            Console.WriteLine(userText.Replace("banana", "orange"));

            return newText;
        }



    }
}
