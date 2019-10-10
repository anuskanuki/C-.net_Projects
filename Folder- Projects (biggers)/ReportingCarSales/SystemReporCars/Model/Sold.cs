using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemReporCars.Model
{
    public class Sold
    {
        public int IdCar { get; set; }
        public string CarName { get; set; }
        public double PriceCar { get; set; }
        public int AmountCars { get; set; }
        public DateTime Date { get; set; }

    }
}
