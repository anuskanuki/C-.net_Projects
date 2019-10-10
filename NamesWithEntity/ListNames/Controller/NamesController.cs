using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListNames.Model;

namespace ListNames.Controller
{
    public class NamesController
    {
        NamesContextDB contextDB = new NamesContextDB();

        //Register a name:
        public bool RegisterName(People peopleItem)
        {
            if (string.IsNullOrWhiteSpace(peopleItem.Name))
                return false;
            contextDB.Names.Add(peopleItem);
            contextDB.SaveChanges();
            return true;
        }

        //Read the names:
        public IQueryable<People> GetNames()
        {
            return contextDB.Names;
        }



    }
}
