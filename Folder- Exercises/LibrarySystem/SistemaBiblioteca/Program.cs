using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * informa que haverá consulta de livro pelo nro de registro do sistema
             */
            Console.WriteLine("Informe o livro a ser consultado");
            //recebe as infos do registro do livro e coloca na variável 
            var numeroDoLivro = Console.ReadLine();
            //compara  livro informado com o que tenho no estoque
            if (numeroDoLivro == "123456")
            {
                Console.WriteLine("Livro indisponível");
                Console.ReadKey();
                return;//fnaliza o metodo, ignora oq tem abaixo dele
            }
            else
            {
                Console.WriteLine("Deseja alocar o livro? (1) SIM  (2) NÃO");
                var resposta = Console.ReadLine();
                if (resposta == "1")
                {
                    Console.WriteLine("Livro alocado");
                    return;
                }

            }
            Console.ReadKey();



        }

    }
}
