namespace CodeFirstTest.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BeerContextDB : DbContext
    {
        public BeerContextDB(string connection) : base(connection)
        {

        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public DbSet<Beer> Beers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
