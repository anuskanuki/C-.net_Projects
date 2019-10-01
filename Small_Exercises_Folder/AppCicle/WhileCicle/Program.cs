using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileCicle
{
    class Program
    {
        ///in the main method, the order of the following commands matters, what comes first and after is sequential followed
        static void Main(string[] args)
        {
            ShowInitialText();
            string name = string.Empty;
            int age = 0;
            char gender = char.MinValue;
            string description = string.Empty;

            while (AskToContinue() == 1)
            {
                name = AskName();
                age = AskAge(name);
                gender = AskFemaleOrMale(gender);
                description = AskForDescription(description);
            }
            Console.WriteLine($"\n\nYOUR DATA:\nName: {name}\nAge: {age}\nGender: {gender}\nAbout you: {description}\n");
            Console.ReadKey();
        }

        private static char AskFemaleOrMale(char gender)
        {
            Console.WriteLine("\n\nWhat is your gender? FEMALE(F) MALE(M)\n");
            return char.Parse(Console.ReadLine());
        }

        private static string AskForDescription(string description)
        {
            Console.WriteLine("\n\nTell me more about you!\n");
            description=Console.ReadLine();
            return description;
        }

        private static string AskName()
        {
            Console.WriteLine("\n\nWhat is your name?\n");
            return Console.ReadLine();
        }

        /// <summary>
        /// This method ask the user age, to check if the user can have a beer
        /// </summary>
        private static int AskAge(string name)
        {
            Console.WriteLine("\n\nHow old are you?\n");
            int userAge = int.Parse(Console.ReadLine());
            if (userAge >= 21)
            {
                Console.WriteLine($"\n{name}, LET'S HAVE A BEER!!\n");
            }
            else
            {
                Console.WriteLine($"\n{name}, unfortunately,legall1y, you cannot have a beer!");
            }
            return userAge;
        }

        /// <summary>
        /// Method to ask if the user wants to continue
        /// </summary>
        /// <returns>returns the insert value</returns>
        private static int AskToContinue()
        {

            Console.WriteLine("\nLet's talk? Yes(1) No(2)\n");
            return int.Parse(Console.ReadKey().KeyChar.ToString());

        }


        /// <summary>
        /// This method shows a initial text of the Alone system
        /// </summary>
        private static void ShowInitialText()//just show the initial text, didn't have a return, so, void
        {
            Console.WriteLine("------------");
            Console.WriteLine("--Welcome!--");
            Console.WriteLine("------------");
        }

    }
}
