using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;
namespace ListagemDeCervejas.Controller
{
    public class CervejaController
    {
        SistemaCervejaContext sistemaCervejaContext = new SistemaCervejaContext();
        public List<Cerveja> GetCervejas()
        {
            return sistemaCervejaContext.ListaDeCerveja;
        }
        public void AddCerveja(Cerveja cerveja)
        {
            cerveja.Id = sistemaCervejaContext.IdParam++;
            sistemaCervejaContext.ListaDeCerveja.Add(cerveja);
        }
        public double GetValorTotal()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(x => x.Valor);
        }
        public double GetTotalLitros()
        {
            return sistemaCervejaContext.ListaDeCerveja.Sum(x => x.Litros);
        }

    }
}
