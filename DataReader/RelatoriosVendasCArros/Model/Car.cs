using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatoriosVendasCArros.Model
{
    class Car
    {
        public int idCar { get; set; }
        public int amountCar { get; set; }
        public string carName { get; set; }
        public double carPrice { get; set; }
        public DateTime dateCar { get; set; }

        //public Car(int idCar, int amountCar, string carName, double carPrice, DateTime dateCar)
        //{
        //    this.carName = carName;
        //    this.amountCar = amountCar;
        //    this.idCar = idCar;
        //    this.carPrice = carPrice;
        //    this.dateCar = dateCar;
        //}
    }
}
