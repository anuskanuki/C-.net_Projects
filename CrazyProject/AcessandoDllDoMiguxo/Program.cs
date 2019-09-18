using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiblioteca;
namespace AcessandoDllDoMiguxo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MinhaBiblioteca.MinhaAnimacao.DesenhaArvore();
            var teste = new CalculosDeArea();
            Console.WriteLine(teste.CalculaAreaDoQuadrado(3));
            Console.ReadKey();

        }


    }
}
