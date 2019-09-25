using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> namesList = new List<string>()
            { "Anuska", "Guilherme", "Tiffany", "Filipe", "Luiza" };

            var text = namesList.Aggregate((name1, name2) => name1 + "\r\n" + name2);
            Console.WriteLine(text);

            Console.ReadKey();


        }
    }
}
