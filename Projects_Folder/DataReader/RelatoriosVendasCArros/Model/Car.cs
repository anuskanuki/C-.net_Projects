using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSaleReports.Model
{
    public class Car
    {
        public int IdCar { get; set; }
        public int AmountCar { get; set; }
        public string CarName { get; set; }
        public double CarPrice { get; set; }
        public DateTime DateCar { get; set; }

    }
}
