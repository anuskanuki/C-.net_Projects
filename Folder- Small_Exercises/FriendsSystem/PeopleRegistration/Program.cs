using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PeopleRegistration.Model;

namespace PeopleRegistration
{
    class Program
    {
        static List<People> peopleList = new List<People>();
        static int countPeople = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("---- People Registration System ----");
            AskRegistration();
        }

        public static void RegisterPeople()
        {
            Console.WriteLine("Add new people:\n");

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Gender (F) (M): ");
            char gender = char.Parse(Console.ReadLine().ToUpper());

            Console.WriteLine("Height: ");
            double heigth = double.Parse(Console.ReadLine());

            Console.WriteLine("RG: ");
            string rg = Console.ReadLine();

            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();

            peopleList.Add(new People
            {
                Name = name,
                Age = age,
                Gender = gender,
                Height = heigth,
                Rg = rg,
                Cpf = cpf
            });
            countPeople++;
            peopleList.ForEach(i => Console.WriteLine
            ($"Name: {i.Name}\nAge: {i.Age}\nGender: {i.Gender}" +
            $"\nHeight: {i.Height}\nRG: {i.Rg}\nCPF: {i.Cpf}"));
            AskToContinue();
        }

        public static void ShowPeoples()
        {
            if (countPeople != 0)
            {
                Console.Clear();
                Console.WriteLine("\n---- People list ----\n\n");

                peopleList.ForEach(i => Console.WriteLine(i.ToString()));

            }
            AskToContinue();
        }

        public static void AskToContinue()
        {
            Console.WriteLine("\nDo you want to add someone else?\n");
            Console.WriteLine
                ("TYPE 1   - ADD NEW PEOPLE\n" +
                "TYPE 2 - LOG OUT\n" +
                "TYPE 3 - SHOW PEOPLE LIST\n\n");

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    RegisterPeople();
                    break;
                case 2:
                    Console.WriteLine("Shutting down...");
                    Thread.Sleep(1800);
                    break;
                case 3:
                    ShowPeoples();
                    break;

            }
        }

        public static void AskRegistration()
        {
            Console.WriteLine("\nDo you want to registrate someone?\n");
            Console.WriteLine("TYPE 1 - YES\nTYPE 2 - NO\n");
            var answer = int.Parse(Console.ReadLine());

            switch (answer)
            {
                case (1):
                    RegisterPeople();
                    break;

                case (2):
                    Console.WriteLine("Shutting down...");
                    Thread.Sleep(1800);
                    break;
            }
        }



    }
}
