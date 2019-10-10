using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CellPhonesCatalog.Model
{
    public class CellPhone : UserControll
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Brand { get; set; }
        [MaxLength(30)]
        [Required]
        public string Model { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
