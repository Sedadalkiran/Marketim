namespace Marketim.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MarketDB : DbContext
    {
        public MarketDB()
            : base("name=MarketDB3")
        {
        }

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Arrear> Arrears { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Username)
                .IsFixedLength();

            modelBuilder.Entity<Admin>()
                .Property(e => e.Password)
                .IsFixedLength();

            modelBuilder.Entity<Product>()
                .HasMany(e => e.Sales)
                .WithRequired(e => e.Product)
                .WillCascadeOnDelete(false);
        }
    }
}
