using CodeFirstTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CodeFirstTest.Controller;


namespace GambCodeFirst
{
    public class Program
    {

        static BeerController beer = new BeerController();
        static void Main(string[] args)
        {
            beer.AddBeer(new Beer() { BeerName = "Stella" });

            Console.ReadKey();
        }
    }
}
