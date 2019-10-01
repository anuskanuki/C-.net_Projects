using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileReview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter text:");
            var textContent = Console.ReadLine();

            var count = 0;
            while (count < textContent.Length)
            {
                Console.WriteLine(textContent[count]);
                count++;
            }
            Console.ReadKey();
        }


    }
}
