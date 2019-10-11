using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikesRegistration.Model
{
    public class Bike : UserControll
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        public string Model { get; set; }
        [Required]
        [MaxLength(30)]
        public string Brand { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
