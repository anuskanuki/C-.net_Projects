using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RelatoriosVendasCArros.Model;

namespace CarSaleReports.Model
{
    public class LocationContext
    {
        public int IdCountCars { get; set; } = 1001;
        public List<Car> CarsList { get; set; }

        public LocationContext(int idCountCars, List<Car> carsList)
        {
            carsList.Add(new Car() { carName = "Risus Company", amountCar = 18, carPrice = 7200, idCar = idCountCars++, dateCar = DateTime.Parse("29/01/2019") });
            //carsList.Add(new Car("carname", 18, 77.88, idCountCars++, DateTime.Parse("04/09/2018")));

        }





    }
}
