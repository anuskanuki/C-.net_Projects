using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsultByName();

        }

        private static void ConsultByName()
        {

            var content = "nome:Felipe,idade:27;nome:Giomar,idade:17;nome:Edson,Idade:19;nome:Ericledson,idade:75;nome:Junior,idade:45";
            Console.WriteLine("\n+18:\n");
            ListByName(content);
            Console.ReadKey();
        }
        private static void ListByName(string content)
        {
            var infoList = content.Split(';');

            foreach (var item in infoList)
            {
                var infoSplit = item.Split(',');
                var name = infoSplit[0].Split(':')[1];
                var age = int.Parse(infoSplit[1].Split(':')[1]);
                if (age >= 18)
                {
                    Console.WriteLine($"Name: {name}\nAge: {age}");
                }

            }


        }



    }
}
