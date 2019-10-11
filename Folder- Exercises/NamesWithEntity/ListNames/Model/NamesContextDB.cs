using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListNames.Model
{
    public class NamesContextDB : DbContext
    {
        public DbSet<People> Names { get; set; }

    }
}
