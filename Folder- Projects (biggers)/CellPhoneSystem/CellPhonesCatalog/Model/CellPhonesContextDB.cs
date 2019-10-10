using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhonesCatalog.Model
{
    public class CellPhonesContextDB : DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<CellPhone> CellPhones { get; set; }


    }
}
