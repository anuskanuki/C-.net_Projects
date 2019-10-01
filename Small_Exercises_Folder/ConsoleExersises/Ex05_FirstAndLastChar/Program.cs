using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_FirstAndLastChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string userText = string.Empty;

            //int length = userText.Length;

            userText = InitialText(userText);

            Console.WriteLine(Counter(userText));

            Console.ReadKey();
        }



        private static string Counter(string userText)
        {
            string result = string.Empty;
            string first = string.Empty;
            string last = string.Empty;

            for (int i = 0; i < userText.Length; i++)
            {
                if (i == 0)
                {
                    first = userText[i].ToString();
                }
                else if (i == userText.Length - 1)
                {
                    last = userText[i].ToString();
                }
            }
            result = $"\nThe first character in this word is: '{first}', and the last one is: '{last}'";

            return result;
        }




        private static string InitialText(string userText)
        {
            Console.WriteLine("\nWelcome!\n\nPlease, enter a word:");
            userText = Console.ReadLine();
            return userText;
        }
    }
}
