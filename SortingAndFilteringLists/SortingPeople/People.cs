using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingPeople
{
    class People
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public double Wallet { get; set; }
        // var peoplesList = new List<People>();
        public People(int id, string name, DateTime birthDate, double wallet)
        {
            Id = id;
            Name = name;
            BirthDate = birthDate;
            Wallet = wallet;
        }

        //public List<People> ReturnCrescListByName()
        //{
        //    return peoplesList.OrderByDEscending(x => x.Name).ToList<People>();
        //}

        //public List<People> ReturnCrescListByDate()
        //{
        //    return peoplesList.OrderByDEscending(x => x.Name).ToList<People>();
        //}

        //public List<People> ReturnCrescList18()
        //{
        //    return peoplesList.OrderByDEscending(x => x.Name).ToList<People>();
        //}
        //public List<People> ReturnCrescList16()
        //{
        //    return peoplesList.OrderByDEscending(x => x.Name).ToList<People>();
        //}
    }
}
