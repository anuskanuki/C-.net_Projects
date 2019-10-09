using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhonesCatalog.Model
{
    public class User : UserControll
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]//maximum size to the string 
        public string Name { get; set; }
        [MaxLength(30)]
        [Required]
        public string Login { get; set; }
        [MaxLength(30)]
        [Required]
        public string Password { get; set; }
    }
}
