using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string userText = string.Empty;

            userText = InitialText(userText);
            CoutVowels(userText);
            Console.ReadKey();
        }

        private static string CoutVowels(string userText)
        {
            string result = string.Empty;
            int aCount = userText.Split('a').Length - 1;
            int eCount = userText.Split('e').Length - 1;
            int iCount = userText.Split('i').Length - 1;
            int oCount = userText.Split('o').Length - 1;
            int uCount = userText.Split('u').Length - 1;

            result = $"\nNumber of vowels:\n'a':{aCount}\n'e':{eCount}\n'i':{iCount}\n'o':{oCount}\n'u':{uCount}\n";
            Console.WriteLine(result);
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
