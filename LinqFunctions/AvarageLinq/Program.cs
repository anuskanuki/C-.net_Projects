using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AvarageLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Sale> saleList = new List<Sale>()
            {
                new Sale(){Product="Iphone 8 plus - 256GB SpaceGray",Amount=8,Value=4000},
                new Sale(){Product="Iphone 6s - 32GB Silver",Amount=5,Value=3000},
                new Sale(){Product="SONY/SAMSUNG/MOTOROLA trash",Amount=1,Value=1000}
            };
            Console.WriteLine("Products sold average - This month");
            Console.WriteLine(saleList.Average(x => x.Amount));
            Console.WriteLine("Average sold (R$) - This month ");
            Console.WriteLine(saleList.Average(x => (x.Amount * x.Value)));
            Console.ReadKey();

        }
    }
}
