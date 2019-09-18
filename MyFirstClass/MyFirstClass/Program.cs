using MyFirstClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyFirstClass
{
    class Program
    {
        static void Main(string[] args)
        {

            var bikesList = new List<Bike>();

            bikesList.Add(new Bike()
            {

                Brand = "Monark"
            });

            bikesList.Add(new Bike()
            {

                Brand = "Caloi"
            });

            bikesList.ForEach(i => Console.WriteLine($"BikeOn > Brand: {i.Brand}Tires: {i.Tires}"));

            Console.ReadKey();


        }



    }
}
