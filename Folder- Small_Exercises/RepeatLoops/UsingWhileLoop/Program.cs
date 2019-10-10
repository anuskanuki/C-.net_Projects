using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingWhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;
            var par = 4;
            while (count<=100)
            {
                if (count % 2 == 0)
                {
                Console.WriteLine(count.ToString().Replace(count.ToString(),par.ToString()));
                }
                Console.WriteLine(count++);
            }
            Console.WriteLine("Game over");
            Console.ReadKey();

        }
    }
}
