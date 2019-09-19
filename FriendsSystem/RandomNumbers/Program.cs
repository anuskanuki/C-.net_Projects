using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random rdm = new Random();


            for (int i = 0; i < 10; i++)
            {
                int randomValue = rdm.Next(100);

                if (!numbers.Contains(randomValue))
                    numbers.Add(randomValue);
                else
                    i--;//ignores if the value already exists

                Console.WriteLine(numbers[i]);
            }
            
            Console.ReadLine();

        }
    }
}
