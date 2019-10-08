namespace CodeFirstTest.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Beer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string BeerName { get; set; }

        [StringLength(30)]
        public string BeerType { get; set; }

        public double Alcool { get; set; }
    }
}
