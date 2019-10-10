using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Model
{
    public class SistemaCervejaContext
    {
        public List<Cerveja> ListaDeCerveja { get; set; }
        //public List<Cerveja> Cervejas = new List<Cerveja>();
        public int IdParam { get; set; } = 1001;
        public SistemaCervejaContext()
        {
            ListaDeCerveja = new List<Cerveja>();
            ListaDeCerveja.Add(new Cerveja() { Id = IdParam++, Nome = "Imposto é roubo", Alcool = 4.3, Litros = 0.6, Valor = 5 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdParam++, Nome = "Barrigudinho", Alcool = 7.8, Litros = 1.5, Valor = 5 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdParam++, Nome = "Calo", Alcool = 14.2, Litros = 2.0, Valor = 8 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdParam++, Nome = "Psita", Alcool = 3.1, Litros = 1.0, Valor = 7 });
            ListaDeCerveja.Add(new Cerveja() { Id = IdParam++, Nome = "Nesquik", Alcool = 1.9, Litros = 0.5, Valor = 15 });
        }

    }
}
