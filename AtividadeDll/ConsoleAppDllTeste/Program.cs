using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace ConsoleAppDllTeste
{
    class Program
    {
        static DocumentsAutoGenerate docsObject = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            Console.WriteLine("\n---------- Manipulação de pastas em 'Meus Documentos' ----------\n\n");
            Console.WriteLine("Selecione a opção desejada para prosseguir:\n\n");
            InicioDaAplicacao();
        }
        public static void InicioDaAplicacao()
        {
            Console.WriteLine
                ("(1) Criar pasta\n(2) Deletar pasta\n" +
                "(3) Obter pastas do diretórios\n(0) Sair\n");
            int escolha = int.Parse(Console.ReadLine());
            switch (escolha)
            {
                case 1://criar
                    CriacaoDePasta();
                    break;
                case 2://deletar
                    DeletarPasta();
                    break;
                case 3://obter
                    MostrarPastas();
                    break;
                case 0://sair
                    break;
            }
        }
        public static void EscolhaUsuario(int escolha)
        {
            switch (escolha)
            {
                case 1://criar
                    CriacaoDePasta();
                    break;
                case 2://deletar
                    DeletarPasta();
                    break;
                case 3://obter
                    MostrarPastas();
                    break;
                case 0://sair
                    break;
            }

        }

        public static void CriacaoDePasta()
        {
            Console.Clear();
            Console.WriteLine("\n----------- CRIAÇÃO DE PASTA ----------\n\n");
            Console.Write("Informe o nome da pasta: ");
            string nomePasta = Console.ReadLine();
            docsObject.CriarPastaMeusDocumentos(nomePasta);
            Console.Clear();
            Console.WriteLine("\nPasta criada com sucesso!\nLocal: Explorador de Arquivos/Meus Documentos\n");
            ContinuarFluxo();
        }


        public static void ContinuarFluxo()
        {
            Console.WriteLine("O que deseja fazer a seguir?\n");
            InicioDaAplicacao();
        }

        public static void DeletarPasta()
        {
            Console.Clear();
            Console.WriteLine("\n----------- DELETAR PASTA ----------\n\n");
            Console.Write("Informe o nome da pasta a ser deletada: ");
            string nomePasta = Console.ReadLine();
            docsObject.DeletarPastaMeusDocumentos(nomePasta);
            Console.Clear();
            Console.WriteLine("\nPasta deletada com sucesso!\n");
            ContinuarFluxo();
        }

        public static void MostrarPastas()
        {

            Console.WriteLine(docsObject.ObterPastasDiretorioMeuDocumentos());
            Console.ReadKey();
        }


    }
}
