
using EComm.Domain.Entities;
using EComm.Persistance.Configurations;
using Microsoft.EntityFrameworkCore;

namespace EComm.Persistance
{
    public class EcommerceDBContext : DbContext
    {
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<ProductEntity> Products { get; set; }

        public EcommerceDBContext(DbContextOptions<EcommerceDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new OrderConfig());
            modelBuilder.ApplyConfiguration(new ProductConfig());

        }
    }
}
