using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayClass
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] arrayLinear = new string[3] { "Nuki", "Guilherme", "Josecleison" };

            arrayLinear[0] = "Nuki";
            arrayLinear[1] = "Guilherme";
            arrayLinear[2] = "Josecleison";

            List<string> linearList = new List<string>();

            //CTRL + point   show the suggestions when you have underlined a "...". press ENTER to make those automaticly on the code
            linearList.Add("Nuki");
            linearList.Add("Guilherme");
            linearList.Add("Josecleison");


            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(arrayLinear[1]);
            Console.WriteLine(arrayLinear[2]);

           // var keyPress = Console.ReadKey().KeyChar.ToString();


        }
    }
}
