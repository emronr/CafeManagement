using CafeManagement.Domain.Entities.Cafe;
using CafeManagement.Domain.Entities.Menu;
using CafeManagement.Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;

namespace CafeManagement.Domain.Context
{
    public class CafeManagementContext : DbContext
    {
        public CafeManagementContext(DbContextOptions<CafeManagementContext> options) : base(options)
        {
            
        }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
