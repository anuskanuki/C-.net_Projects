using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SumLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            SumIntValues();
            IntSumList();
            SumCandyesKidsList();
            Console.ReadKey();
        }

        /// <summary>
        /// This method shows the primitives values sum of int numbers
        /// </summary>
        private static void SumIntValues()
        {
            Console.WriteLine("Int values - Sum - Array");
            int[] intCollection = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(intCollection.Sum());
        }

        /// <summary>
        /// This method use sum in a int list
        /// </summary>
        private static void IntSumList()
        {
            Console.WriteLine("Int values - Sum - List");
            List<int> intList = new List<int>()
            {
                1,2,3,4,5
            };
            Console.WriteLine(intList.Sum());

        }

        /// <summary>
        /// This method sum the kid amount of candyes
        /// </summary>
        private static void SumCandyesKidsList()
        {
            Console.WriteLine("Sum - Kids candyes");
            List<Kid> KidsList = new List<Kid>()
            {
            new Kid()
            {
                Name="Kate",
                Candyes=8
             },
            new Kid()
            {
                    Name = "Hitler",
                    Candyes = 67
            }
            };
            Console.WriteLine(KidsList.Sum(x => x.Candyes));
        }

    }
}
