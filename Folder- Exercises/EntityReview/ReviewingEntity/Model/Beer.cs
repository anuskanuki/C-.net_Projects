using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewingEntity.Model
{
    //first, we let the class public
    public class Beer
    {
        [Key]//+ ctrl + . = to add the using , put primary key auto increment
        public int Id { get; set; }
        [StringLength(50)]//beer name -> 50 chars max
        [Required]//not null
        public string BeerName { get; set; }
        [StringLength(30)]
        public string BeerType { get; set; }
        public double Alcool { get; set; }

    }
}
