namespace _2015webapi.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class govdataModel1 : DbContext
    {
        public govdataModel1()
            : base("name=govdataModel1")
        {
        }

        public virtual DbSet<foodapedia03> foodapedia03 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
