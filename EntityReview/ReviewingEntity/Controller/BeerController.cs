using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewingEntity.Model;
namespace ReviewingEntity.Controller
{
    //let the class public
    public class BeerController
    {
        BeerContextDB contextDB = new BeerContextDB();
        public void AddBeer(Beer beerItem)
        {
            if (beerItem.BeerName.Contains("Beer"))
                contextDB.Beers.Add(beerItem);

            contextDB.SaveChanges();
        }

        public IQueryable<Beer> GetBeers()
        {
            return contextDB.Beers.Where(x => x.BeerName.Contains("Beer"));
        }


    }
}
