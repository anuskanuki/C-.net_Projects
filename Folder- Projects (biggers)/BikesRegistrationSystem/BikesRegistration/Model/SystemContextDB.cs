using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikesRegistration.Model
{
    public class SystemContextDB : DbContext
    {
        public DbSet<Bike> Bikes { get; set; }//this is a table in our Data Base
    }
}
