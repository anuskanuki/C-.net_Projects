using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Model
{
    public class UserControll
    {
        public bool Active { get; set; } = true;
        public int UserInsertion { get; set; } = 0;
        public int UserAlteration { get; set; } = 0;
        public DateTime InsertionDate { get; set; } = DateTime.Now;
        public DateTime AlterationDate { get; set; } = DateTime.Now;
    }
}
