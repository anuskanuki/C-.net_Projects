using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerificarTamanhoNome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informar o nome a ser calculado");

            var nameLength = Console.ReadLine();

            Console.WriteLine($"O tamanho do nome é: {nameLength.Replace(" ", "").Length}");//.net permite isso

            Console.ReadKey();

        }
    }
}
