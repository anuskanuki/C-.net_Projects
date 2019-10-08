using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ReviewingEntity.Model;
using ReviewingEntity.Controller;

namespace VisualApplication
{
    class Program
    {
        //1 Set this application as startup project
        //2 add EntityFramework to our console project
        //3 Add the "using" above using system.data.entity
        //4 add the reference of our library location

        //static BeerContextDB beer = new BeerContextDB();

        static BeerController beer = new BeerController();
        static void Main(string[] args)
        {
            /*beer.Beers.Add(new Beer() { BeerName = "Test Name" });
            beer.SaveChanges();*/
            /*beer.Beers.ToList<Beer>().ForEach(x => Console.WriteLine(x.BeerName));*/

            beer.AddBeer(new Beer() { BeerName = "Tonic Beer" });
            beer.GetBeers().ToList<Beer>().ForEach(x => Console.WriteLine(x.BeerName));

            Console.ReadKey();

        }
    }
}
