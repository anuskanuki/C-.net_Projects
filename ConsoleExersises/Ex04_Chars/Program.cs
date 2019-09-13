using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string userText = string.Empty;

            userText = InitialText(userText);

            Console.WriteLine(CharsCounter(userText));

            Console.ReadKey();

        }

        public static string CharsCounter(string userText)
        {
            int count = 0;
            string result = string.Empty;
            count = userText.Length;

            result = $"Your text have {count} characters";
            return result;
        }
        

        private static string InitialText(string userText)
        {
            Console.WriteLine("\nWelcome!\n\nPlease, enter a text or a message:");
            userText = Console.ReadLine();
            return userText;
        }
    }
}
