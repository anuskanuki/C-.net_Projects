using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class EntityContextDB : 
        DbContext//classe pronta que tem todos os processos de conexão com o banco de dados
        //listagem das tabelas e seleção de informações
    {

     public DbSet//palavra reservada para entity que indica que vamos definir uma tabela
            //no nosso banco de dados
            <Pessoa> //definir nossa tabela pessoa, pessoa é o nome da tabela no banco
            ListaDePessoas { get; set; }   //liberamos a tabela para acesso. "listaDePessoas"
        //é o nome da tabela "pessoa" que defini antes, mas listaepessoas é meu nome de acesso aq


    }
}
