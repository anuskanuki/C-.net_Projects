using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTypesConcat
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Type:\nNAME AND PRESS ENTER\nAge AND PRESS ENTER\nDESCRIPTION AND PRESS ENTER\n    ");

            var templateTest = @"User name: {0} 
Age: {1}
Description: {2}";


            var finishText = string.Format(templateTest
                , Console.ReadLine()
                , Console.ReadLine()
                , Console.ReadLine());

                                   
            Console.WriteLine(finishText);
            
            Console.ReadKey();


                        

        }
    }
}
