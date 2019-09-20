using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryLocation.Model
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public int UserCreation { get; set; }
        public int UserChange { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ChangeDate { get; set; }

    }
}
