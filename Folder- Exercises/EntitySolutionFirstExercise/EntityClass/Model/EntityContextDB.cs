using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
   public class EntityAlunosContextDB : DbContext//cria a conexão com o banco de dados
    {

        public DbSet<Aluno> ListaDeAlunos { get; set; }


    }
}
