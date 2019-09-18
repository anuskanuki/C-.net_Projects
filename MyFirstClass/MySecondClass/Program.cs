using MySecondClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySecondClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFruisBasket = new List<Fruits>();//ctrl + .

            myFruisBasket.Add(new Fruits()
            {
                Name = "Banana",
                Amount = 5
            });

            myFruisBasket.Add(new Fruits()
            {
                Name = "Grape",
                Amount = 3
            });


            myFruisBasket.ForEach(i =>
            Console.WriteLine($"Name {i.Name} Amount {i.Amount}"));

            Console.ReadKey();

        }
    }
}
