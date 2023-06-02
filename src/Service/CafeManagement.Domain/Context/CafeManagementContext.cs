using CafeManagement.Domain.Entities.Cafe;
using CafeManagement.Domain.Entities.Menu;
using CafeManagement.Domain.Entities.Order;
using CafeManagement.Domain.Seed;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CafeManagement.Domain.Context
{
    public class CafeManagementContext : DbContext
    {
        //public CafeManagementContext(DbContextOptions<CafeManagementContext> options) : base(options)
        //{
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = localhost; Database=CafeManagementDB;Integrated Security=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().Navigation(x => x.OrderDetails).AutoInclude();
            modelBuilder.Entity<Order>().Navigation(x => x.Table).AutoInclude();
            modelBuilder.Entity<OrderDetail>().Navigation(x => x.Product).AutoInclude();
            modelBuilder.Entity<Product>().Navigation(x => x.Category).AutoInclude();

        }

        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
