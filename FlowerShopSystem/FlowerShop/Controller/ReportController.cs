using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowerShop.Model;

namespace FlowerShop.Controller
{
    public class ReportController
    {
        FlowersContextDB contextDB = new FlowersContextDB();

        public bool InsertFlower(Flower flowerItem)
        {
            if (string.IsNullOrWhiteSpace(flowerItem.FlowerName))
                return false;

            contextDB.Flowers.Add(flowerItem);
            contextDB.SaveChanges();
            return true;
        }

        public IQueryable<Flower> GetFlowers()
        {
            return contextDB.Flowers.Where(x => x.Active == true);
        }

    }
}
