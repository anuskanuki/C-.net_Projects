using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemReporCars.Model
{
    public class SalesSystemContext
    {
        /// <summary>
        /// Data Mass intern
        /// </summary>
        private List<Sold> SoldList { get; set; }

        /// <summary>
        /// Constructor - prepare our data mass
        /// </summary>
        public SalesSystemContext()
        {
            //create our list at the memory
            SoldList = new List<Sold>();
            SoldList.Add(new Sold() { IdCar = 1, CarName = "Risus Company", PriceCar = 7200, AmountCars = 18, Date = DateTime.Parse("29/01/2019")});
            SoldList.Add(new Sold { IdCar = 2, CarName = "Risus Associates", PriceCar = 9961, AmountCars = 04, Date = DateTime.Parse("10/02/2019")});
            SoldList.Add(new Sold { IdCar = 3, CarName = "Et Libero Proin Foundation", PriceCar = 8710, AmountCars = 17, Date = DateTime.Parse("24/01/2019")});


        }

        public List<Sold> PublicSalesList { get { return SoldList; } }
    }
}
