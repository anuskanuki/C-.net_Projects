using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikesRegistration.Model
{
    public class UserControll
    {
        public bool Active { get; set; } = true;
        public int UserCreation { get; set; } = 0;
        public int UserChange { get; set; } = 0;
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public DateTime ChangeDate { get; set; } = DateTime.Now;
    }
}
