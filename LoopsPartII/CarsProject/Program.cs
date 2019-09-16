using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            searchForCar();
        }

        private static void ListInfosByName(string content)
        {
            var infoList = content.Split(';');
            foreach (var item in infoList)
            {
                var splitInfo = item.Split(',');
                var carName = splitInfo[0].Split(':')[1];

                Console.WriteLine($"Car name: {carName}");

            }


        }

        private static void searchForCar()
        {
            //database:
            var content = "Carro:Kwid,Year:2015,Brand:Renault;Carro:Gol,Year:2010,Brand:Volkswagen;Carro:Fox,Year:2011,Brand:Volkswagen";
            ListInfosByName(content);


            Console.WriteLine("Enter a registered car: ");
            var carName = Console.ReadLine();

            var selectedVeichle = ReturnVeichle(content, carName);

            Console.WriteLine(string.Format("The car{0} is from {1} and fabricated in {2}",
                GetValue(selectedVeichle, "Carro"),
                GetValue(selectedVeichle, "Brand"),
                GetValue(selectedVeichle, "Year")));

            Console.ReadKey();

        }

        private static string[] ReturnVeichle(string content, string veichleName)
        {
            var infoList = content.Split(';');

            foreach (var item in infoList)
            {
                var splitInfo = item.Split(',');

                var carName = GetValue(splitInfo, "Carro");

                if (veichleName == carName)
                    return splitInfo;
            }
            return new string[0];
        }


        private static string GetValue(string[] collection, string type)
        {
            foreach (var item in collection)
            {
                var breakingInfo = item.Split(':');
                if (breakingInfo[0] == type)
                    return breakingInfo[1];
            }
            return string.Empty;
        }











        private static void ForeachSplitWithList()
        {
            var content = "Name:Anuska,Age:19;Name:Filipe,Age:22;Name:Veber,Age:26";

            var infoList = content.Split(';');
            Console.WriteLine("Registered users:");
            foreach (var item in infoList)
            {
                //agora tenho 3 "vetores" com as infos: nome: ...(posição 0), idade:... (posição 1)cada, e cada um, tem a posição 0 e a posição 1
                //abaixo eu peço para exibir, do meu vetor splitado (tamanho 3), todas posições 0, ou seja, os nomes, pq tão antes da virgula

                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Enter a registered name: ");
            var searchedName = Console.ReadLine();

            foreach (var item in infoList)
            {
                var infoSplit = item.Split(',');

                var name = infoSplit[0].Split(':')[1];
                var age = infoSplit[1].Split(':')[1];

                if (name == searchedName)
                {
                    Console.WriteLine($"{name} is {age} years old.");
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Searc method with split and foreach
        /// </summary>
        private static void ForEachWithSplit()
        {
            var textContent = "Here i have a text for example and my name is Anuska";

            Console.WriteLine("\n\n" + textContent + "\n\n");
            Console.WriteLine("Enter the word for search:\n");
            var word = Console.ReadLine();

            var splitTextContent = textContent.Split(';');//a cada ponto e virgula, separa na array do split, se eu colocasse aqui um (' '), ele separaria a cada espaço

            foreach (var item in splitTextContent)
            {
                if (word == item)
                    Console.WriteLine("\n\nWord sucessfully found!\n\n");
            }
            Console.ReadKey();
        }
        private static void ForEachWithSplitAndDot()
        {
            Console.WriteLine("Enter your name:\n\n");
            //var yourName = "Anuska";
            var textContent = $"Aqui; temos; um; texto; que; iremos; mudar; para; uma; coleção;e; vamos; colocar; isto;{Console.ReadLine()}; para; depois; usar; com; o; replace";

            // textContent = textContent.Replace(';', ' ');

            //Console.WriteLine("\n\n" + textContent + "\n\n");


            Console.WriteLine("\n\nEnter the word for search:\n\n");
            var word = Console.ReadLine();

            var splitTextContent = textContent.Split(';');//a cada ponto e virgula, separa na array do split, se eu colocasse aqui um (' '), ele separaria a cada espaço


            foreach (var item in splitTextContent)
            {
                if (word == item)
                    Console.WriteLine("\n\nWord sucessfully found!\n\n");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// This method shows how to use foreach under a characters array,
        /// texts, words, etc...
        /// </summary>
        private static void InitializingForEach01()
        {
            Console.WriteLine("Enter text");
            var textContent = Console.ReadLine();

            foreach (var item in textContent)
            {
                if (item == 'e')//aqui ele ignora o "e"
                    continue;
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
