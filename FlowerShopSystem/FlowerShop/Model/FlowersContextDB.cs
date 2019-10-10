using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Model
{
    public class FlowersContextDB : DbContext
    {
        public DbSet<Flower> Flowers { get; set; }
    }
}
