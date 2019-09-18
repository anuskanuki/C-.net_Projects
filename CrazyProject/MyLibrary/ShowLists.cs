using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class ShowLists
    {

        public static void RunLists()
        {
            CarsList();
            BeerList();
        }


        public static void CarsList()
        {
            //Console.Clear();
            Console.WriteLine("\n--- Cars Brand List: ---\n");
            Console.WriteLine(@"Renault
Volkswagen
KIA
Hyundai
Fiat
Ford");

        }
        public static void BeerList()
        {
            //  Console.Clear();
            Console.WriteLine("\n--- Beer List: ---\n");
            Console.WriteLine(@"Skol 
Brahma
Itaipava
Amstel
Devassa
Heineken
Budweiser
Antarctica");

        }

    }


}
