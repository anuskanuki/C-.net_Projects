using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListNames.Controller;
using ListNames.Model;

namespace PrintingNamesView
{
    class Program
    {
        static NamesController namesController = new NamesController();
        static void Main(string[] args)
        {
            namesController.RegisterName(new People() { Name = "Anuska" });

            namesController.GetNames().ToList().ForEach(x => Console.WriteLine(x.Name));
            Console.ReadKey();

        }
    }
}
