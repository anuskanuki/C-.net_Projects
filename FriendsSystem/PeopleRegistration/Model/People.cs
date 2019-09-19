using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleRegistration.Model
{
    class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public double Height { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }

        override
        public string ToString()
        {
            string result = string.Empty;
            result = $"Name: {Name}\nAge: {Age}\nGender: {Gender}" +
            $"\nHeight: {Height}\nRG: {Rg}\nCPF: {Cpf}\n\n";
            return result;
        }

    }
}
