using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewFor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text");
            var textContent = Console.ReadLine();

            for (int i = 0; i < textContent.Length; i++)
            {
                Console.Write(textContent[i]);
            }
            Console.ReadKey();


        }



    }
}
