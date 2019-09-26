using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarSaleReports.Model;

namespace CarSaleReports.Controller
{
    public class CarsController
    {
        private LocationContext DataBaseContext = new LocationContext();

        public List<Car> ReturnsCarsList()
        {
            return DataBaseContext.CarsList;
        }

        public void ShowInfo()
        {
            ReturnsCarsList().ToString();
        }

    }
}
