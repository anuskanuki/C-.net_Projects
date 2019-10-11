using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowerShop.Model
{
    public class Flower : UserControll
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string FlowerName { get; set; }
        public int FlowerAmount { get; set; } = 1;


    }
}
