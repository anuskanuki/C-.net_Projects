using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityClass.Model
{
    public class Aluno//é a tabela do meu banco de dados 
    {

        [Key]
        public int Id { get; set; }
        [Required]//not null
        [StringLength(50)]//until 30 chars
        public string Nome { get; set; }
        [Required]
        public int Idade { get; set; }

    }
}
