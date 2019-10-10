using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLocation.Model
{
    public class SystemContextDB : DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Book> Books { get; set; }
    }
}
