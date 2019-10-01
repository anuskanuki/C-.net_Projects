using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCervejas.Model;
using ListagemDeCervejas.Controller;
namespace Main
{
    class Program
    {
        static CervejaController cervejaControllerObject = new CervejaController();

        static void Main(string[] args)
        {
            MostrarLista();
            Console.ReadKey();
        }
        public static void MostrarLista()
        {
            //string template = $"Id: {0,3} Nome: {1,10} Valor: {2,4} Alcool: {3,4} Litros: {4,4}";
            //string formatado = string.Format(template,
            //    param.Id, param.Nome, param.Valor.ToString("C2"), param.Alcool, param.Litros);
            //cervejaControllerObject.GetCervejas().ForEach(x => Console.WriteLine
            //(formatado));

            cervejaControllerObject.GetCervejas().ForEach(x => Console.WriteLine
       ($"Id: {x.Id} Nome: {x.Nome} Valor: {x.Valor} Alcool: {x.Alcool} Litros: {x.Litros}"));
        }

        public static void AddCervejinha(Cerveja cervejinha)
        {
            Console.Write("Digite o Nome da cerveja");
            string nomeC = Console.ReadLine();
            Console.Write("Quantidade(litros): ");
            var litrosC = double.Parse(Console.ReadLine());
            Console.Write("Teor alcoolico: ");
            var alcoolC = double.Parse(Console.ReadLine());
            Console.Write("Preço: ");
            var valorC = double.Parse(Console.ReadLine());
            cervejaControllerObject.AddCerveja(new Cerveja()
            {
                Nome = nomeC,
                Litros = litrosC,
                Valor = valorC,
                Alcool = alcoolC
            });
        }



    }
}
