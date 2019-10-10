using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo
{
    class Program

    {
        const int constantTest = 99999;
      
        static void Main(string[] args)
        {
            string firstTest = string.Empty;
            String anotherFirstTest = string.Empty;
            bool testComp = "123" == "123";
            Boolean anotherTestComp = "123" == "123";
            int intNumber = 34;


            var outTest = "";
            outTest = "test";


            var test1 = "String";//string
            var test2 = 'A';//char
            var test3 = 8;//int 
            var test4 = 4.9;//double
            var test5 = 0x00F;//hex
            Console.WriteLine(constantTest);
            Console.WriteLine(outTest);
            Console.ReadKey();
            
        }
    }
}
