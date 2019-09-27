using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Controller;
using ListagemDeCervejas.MODEL;
namespace ApresentandoOsAlcoolatras
{
    class Program
    {
        static CervejaController cervejaController = new CervejaController();
        static void Main(string[] args)
        {
            cervejaController.AdicionarCervejas(new Cerveja()
            {
                Id = cervejaController.GetCervejas().Count + 1,
                Nome = "Juliana",
                Litros = 0.600,
                Alcool = 8,
                Valor = 0.98
            });

            cervejaController.GetCervejas().ForEach
                (x => Console.WriteLine
                ($"Id {x.Id} Nome: {x.Nome} Litros: " +
                $"{x.Litros} Valor: {x.Valor} Alcool: {x.Alcool}"));

            Console.WriteLine("Total em litros: " + cervejaController.ValorTotalEmLitros());
            Console.WriteLine("Valor total: " + cervejaController.ValorTotal());

            Console.ReadKey();
        }
    }
}
