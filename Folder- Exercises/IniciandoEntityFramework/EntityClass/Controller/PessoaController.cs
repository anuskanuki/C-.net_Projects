using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityClass.Model;


namespace EntityClass.Controller
{
    public class PessoaController
    {

        //Realizzo minha conexão com o banco e dados
        EntityContextDB contextDB = new EntityContextDB();

        public IQueryable//nossa primeira interface com classe IQueryable, que tem varias
                         //funiconalidades prontas para usar igual ao banco de dados com os selects
            <Pessoa>//definimos o tipo que vai retornar
            GetPessoas()//nome do metodo
        {
            return contextDB.ListaDePessoas;//retornamos a lista de pessoas
        }

        /// <summary>
        /// Metodo p add Pessoa no banco de dados
        /// </summary>
        /// <param name="itemPessoa">Item pessoa</param>
        public void AddPessoa(Pessoa itemPessoa)
        {
            contextDB.//nosso banco de dados
                ListaDePessoas.Add(itemPessoa);//adicionamos um item na tabela pessoa
            contextDB.SaveChanges();//salvamos no banco
        }

    }
}
