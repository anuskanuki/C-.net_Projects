using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            searchForCar();
        }


        private static void searchForCar()
        {   
            //database:
            var content = "Carro:Kwid,Year:2015,Marca:Renault;Carro:Gol,Year:2010,Marca:Volkswagen;Carro:Fox,Year:2011,Marca:Volkswagen";

            var infoList = content.Split(';');//split by car, so: each car have year and brand
            Console.WriteLine("Registered cars:");
            foreach (var item in infoList)
            {
                Console.WriteLine(item.Split(',')[0]);
            }

            Console.WriteLine("Enter a registered car: ");
            var searchedName = Console.ReadLine();

            foreach (var item in infoList)
            {
                var infoSplit = item.Split(',');//split by car(each car have year, name and brand)

                var car = infoSplit[0].Split(':')[1];//split by the car name
                var year = infoSplit[1].Split(':')[1];//split by year
                var brand = infoSplit[2].Split(':')[1];//split by brand

                if (car == searchedName)
                {
                    Console.WriteLine($"{car} is a {brand} car from {year}.");
                }
            }
            Console.ReadKey();

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
