using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompactarTexto
{
    class Program
    {
        static void Main(string[] args)
        {

            var firstText = "Hi, my name is Nuki and soon me Nuki have to eat because i love to eat in my life Nuki likes eating and Nuki likes ";

            Console.WriteLine(firstText);
            Console.WriteLine($"Text contains: {firstText.Length} characters");


            firstText = firstText
                
                .Replace("Nuki", "1")
                .Replace("my", "0")
                .Replace("eat","2");


            Console.WriteLine(firstText);
            Console.WriteLine($"Text contains: {firstText.Length} characters");


            Console.ReadKey();


        }
    }
}
