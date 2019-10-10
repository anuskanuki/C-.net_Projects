using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstTest.Model;

namespace CodeFirstTest.Controller
{
    public class BeerController
    {
        BeerContextDB contextDB = new BeerContextDB
            (@"data source=(localdb)\MSSQLLocalDB;initial 
catalog=ReviewingEntity.Model.BeerContextDB;integrated 
security=True;MultipleActiveResultSets=True;App=EntityFramework");
        public void AddBeer(Beer itemBeer)
        {
            contextDB.Beers.Add(itemBeer);
            contextDB.SaveChanges();
        }
    }
}
