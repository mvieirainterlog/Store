using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Store.Models;
using System.Reflection.Metadata;

namespace Store.Data
{
    public class StoreDBContext : IdentityDbContext
    {
        public StoreDBContext(DbContextOptions<StoreDBContext> options)
            : base(options)
        {
        }


        public DbSet<Store.Models.Order> Orders { get; set; }
        public DbSet<Store.Models.OrderStatus> OrderStatus { get; set; }
        public DbSet<Store.Models.Product> Products { get; set; }
        public DbSet<Store.Models.OrderProduct> OrdersProducts { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            //      modelBuilder.Entity<Product>()
            //      .HasOne(b => b.OrderProduct)
            //      .WithOne(i => i.Product)
            //      .HasForeignKey<OrderProduct>(b => b.ProductForeignKey);

            //      modelBuilder.Entity<Order>()
            //.HasOne(b => b.OrderProduct)
            //.WithOne(i => i.Order)
            //.HasForeignKey<OrderProduct>(b => b.OrderForeignKey);

            modelBuilder.Entity<OrderProduct>()
                .HasKey(c => new { c.OrderId, c.ProductId });


          


        }

    }
}