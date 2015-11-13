namespace _2015webapi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Fooddb : DbContext
    {
        public Fooddb()
            : base("name=Fooddb")
        {
        }

        public virtual DbSet<Fooditem> Fooditems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
