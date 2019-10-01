using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLearning
{
    class Program
    {
        static List<string> myList = new List<string>()
            {
                "Anuska",
                "Irineu",
                "Serilop"
            };
        static void Main(string[] args)
        {
            AddItensToTheList();
            ListInfo();
            Console.ReadKey();
        }


        /// <summary>
        /// Method to add a new iten in the list
        /// </summary>
        private static void AddItensToTheList()
        {
            var newName = string.Empty;
            Console.Clear();
            Console.WriteLine("\n\nEnter a name to add at the list!\n\n");
            newName = Console.ReadLine();
            myList.Add(newName);
            Console.Clear();
            Console.WriteLine($"\n{newName} added to the list\n\n");
            Console.WriteLine("Do you want to add more values? yes(Y) other key(N)");
            if (Console.ReadKey().KeyChar.ToString().ToLower() == "y")//tipo colocar um nro em modulo, nesse caso coloquei tudo pra minusculo com o toLower, independentemente fica minusculo pra ele pegar o "valor" nao o jeto q foi escrito (maiusc\minusc), o toUpper deixa maiusculo
                AddItensToTheList();//FUNÇÃO RECURSIVA
        }


        /// <summary>
        /// Method to show the list
        /// </summary>
        private static void ListInfo()
        {
            Console.Clear();
            Console.WriteLine("\n\nThere is your new list:\n\n");
            foreach (var item in myList)
                Console.WriteLine(item.ToUpper());
        }



    }
}
