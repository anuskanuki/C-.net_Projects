using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLocation.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; } = true;//default: true(active)
        public int UserCreation { get; set; }
        public int UserChange { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ChangeDate { get; set; }

    }
}
