using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Controller;
using EntityClass.Model;

namespace AcessandoEntity
{
    class Program
    {
        static PessoaController pessoa = new PessoaController();//instanciando pessoa controller

        static void Main(string[] args)
        {
            pessoa.AddPessoa(new Pessoa()
            {
                Nome = "Felipe"
            });

            pessoa.GetPessoas().ToList<Pessoa>().ForEach(x => Console.WriteLine(x.Nome));//pega
            //as pessoas do meu banco de dados, mostra em forma de lista
            Console.ReadKey();

        }
    }
}
