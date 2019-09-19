using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRegistration.Model
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Value { get; set; }
        public string CarLicensePlate { get; set; }

        override
       public string ToString()
        {
            string result = string.Empty;
            result = $"Brand: {Brand}\nModel: {Model}\nYear: {Year}" +
            $"\nValue: {Value}\nCar license Plate: {CarLicensePlate}\n\n";
            return result;
        }
    }
}
