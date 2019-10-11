using BikesRegistration.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikesRegistration.Controller
{
    public class BikeController
    {
        SystemContextDB contextDB = new SystemContextDB();

        #region CRUD
        //CRUD
        //CREATE
        public bool AddBike(Bike itemBike)
        {
            //validations
            if (string.IsNullOrWhiteSpace(itemBike.Model))
                return false;
            if (string.IsNullOrWhiteSpace(itemBike.Brand))
                return false;
            if (itemBike.Price < 0)
                return false;

            contextDB.Bikes.Add(itemBike);
            contextDB.SaveChanges();
            return true;
        }

        //READ
        public IQueryable<Bike> GetBikes()
        {
            return contextDB.Bikes.Where(x => x.Active == true);
        }

        //UPDATE
        public bool UpdateBike(Bike item)
        {
            var bike = contextDB.Bikes.FirstOrDefault(x => x.Id == item.Id);

            if (bike == null)
                return false;
            else
            {
                bike.ChangeDate = DateTime.Now;
            }
            contextDB.SaveChanges();

            return true;
        }

        //DELETE
        public bool RemoveBike(int bikeId)
        {
            var bikeRemoved = contextDB.Bikes.FirstOrDefault(x => x.Id == bikeId);

            if (bikeRemoved == null)
                return false;
            bikeRemoved.Active = false;

            contextDB.SaveChanges();
            return true;
        }
        #endregion


    }
}
