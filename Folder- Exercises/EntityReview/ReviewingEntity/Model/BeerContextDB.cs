using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewingEntity.Model
{
    public class BeerContextDB : DbContext//Db context to make things with the data base
    {
        public DbSet<Beer> Beers { get; set; }//definition of our table inside our data base. DBSet it is to transform in a table




    }
}
