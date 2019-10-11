using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;
namespace EntityClass.Controller
{
    public class AlunoController
    {
        EntityAlunosContextDB contextDB = new EntityAlunosContextDB();//instancio a conexão com o banco de dados

        public IQueryable<Aluno> GetAlunos()
        {
            //retorna os alunos
            return contextDB.ListaDeAlunos;
        }


        public void AddAluno(Aluno itemAluno)
        {
            contextDB.ListaDeAlunos.Add(itemAluno);
            contextDB.SaveChanges();
        }

    }
}