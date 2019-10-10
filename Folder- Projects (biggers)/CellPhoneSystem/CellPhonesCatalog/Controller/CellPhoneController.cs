using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CellPhonesCatalog.Model;
namespace CellPhonesCatalog.Controller
{
    //1 turn the class into public
    //2 Using - model folder
    //3 New instance from our contextDB
    public class CellPhoneController
    {
        CellPhonesContextDB contextDB = new CellPhonesContextDB();
        #region CRUD
        //CRUD:

        //Create
        /// <summary>
        /// This method validates and isert the registers inside the system
        /// </summary>
        /// <param name="itemCellPhone">Our new phone</param>
        /// <returns>Returns true to a valid item</returns>
        public bool AddCellPhone(CellPhone itemCellPhone)
        {
            //validations
            if (string.IsNullOrWhiteSpace(itemCellPhone.Brand))
                return false;
            if (string.IsNullOrWhiteSpace(itemCellPhone.Model))
                return false;
            if (itemCellPhone.Price <= 0)
                return false;
            contextDB.CellPhones.Add(itemCellPhone);//insert into CellPhones
            contextDB.SaveChanges();
            return true;
        }
        //Read
        /// <summary>
        /// This method returns our actives cellphones list only
        /// </summary>
        /// <returns>QueryList of filtered actives cellphones</returns>
        public IQueryable<CellPhone> GetCellPhones()
        {
            return contextDB.CellPhones.Where(x => x.Active == true);//bring just the actives cellphones
        }
        //Update
        /// <summary>
        /// This method updates a valid register of a cellphone at the system
        /// </summary>
        /// <param name="item">The cellphone to be updated(Item to be updated)</param>
        /// <returns>Returns true if the item exists</returns>
        public bool UpdateCellPhone(CellPhone item)//item is the updated cell phone
        {
            var cellPhone =//variable to the phone
                contextDB.//using the data base
                CellPhones.//our table who have the phones
                FirstOrDefault(x => x.Id == item.Id);//where th old id is like the new id,
            //so, just changing the info, from this phone(te informated id)

            if (cellPhone == null)//verify if he found a cell phone
                return false;//if negaive, return false
            else
            {
                cellPhone.AlterationDate = DateTime.Now;//we update the alteration 
                //date from our phone, since we just updated, register this alteration
            }
            contextDB.SaveChanges();//save the canges at the Data Base

            return true;//we return that have been updated
        }
        //Delete
        /// <summary>
        /// This method is just to disable an item in our system
        /// </summary>
        /// <param name="id">Id that we're going to disable</param>
        /// <returns>Returns true in sucess case</returns>
        public bool RemoveCellPhone(int id)//set active as disabled
        {
            var cellPhone = contextDB.CellPhones.FirstOrDefault(x => x.Id == id);

            //validations
            if (cellPhone == null)
                return false;
            cellPhone.Active = false;

            contextDB.SaveChanges();
            return true;//true as "removing cellphone sucessfully"
        }
        #endregion
    }
}
