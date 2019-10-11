using EntityClass.Controller;
using EntityClass.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola
{
    class Program
    {
        static AlunoController alunos = new AlunoController();
        static void Main(string[] args)
        {
            //alunos.AddAluno(new Aluno()
            //{
            //    Nome = "Tiffany",
            //    Idade = 12
            //});

            //alunos.AddAluno(new Aluno()
            //{
            //    Nome = "Anuska",
            //    Idade = 20
            //});

            //alunos.AddAluno(new Aluno()
            //{
            //    Nome = "Francisco",
            //    Idade = 14
            //});

            MenuSistema();
            Console.ReadKey();

        }

        private static void MenuSistema()
        {
            Console.WriteLine("----- Bem-vindo -----\n");
            Console.WriteLine("(1)- Cadastrar novo aluno");
            Console.WriteLine("(2)- Listar alunos");
            var escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("----- CADASTRAR  NOVO ALUNO -----\n");
                    Console.Write("Nome: ");
                    var nomeAlunoNovo = Console.ReadLine();
                    Console.Write("Idade: ");
                    var idadeAlunoNovo = int.Parse(Console.ReadLine());
                    alunos.AddAluno(new Aluno()
                    {
                        Nome = nomeAlunoNovo,
                        Idade = idadeAlunoNovo
                    });
                    Console.WriteLine("Cadastro finalizado com sucesso!");
                    Console.WriteLine("\n\nPressione ENTER para voltar ao menu");
                    Console.ReadKey();
                    MenuSistema();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("----- Alunos Cadastrados -----\n");
                    alunos.GetAlunos().ToList<Aluno>().ForEach
                        (x => Console.WriteLine(x.Nome, x.Idade));
                    Console.WriteLine("\n\nPressione ENTER para voltar ao menu");
                    Console.ReadKey();
                    MenuSistema();
                    break;
            }

        }

    }
}
