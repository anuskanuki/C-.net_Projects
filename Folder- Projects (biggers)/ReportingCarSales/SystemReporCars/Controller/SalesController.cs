using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemReporCars.Model;

namespace SystemReporCars.Controller
{
    public class SalesController
    {
        SalesSystemContext salesContextObject = new SalesSystemContext();

        public List<Sold> GetSolds(int month = 0)//when we put "=0", an initialization to the param, when we call him, culd be without param, but, it will be the default one
        {
            if (month == 0)
                return salesContextObject.PublicSalesList;//list without filter
            else
                return salesContextObject.PublicSalesList.FindAll(x => x.Date.Month == month);
        }


    }
}
