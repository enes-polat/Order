using ECommerce.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace ECommerce.Data.Context
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)
        {

        }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<CustomerAddress> CustomerAddress { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Customer>()
                .HasData(
                    new Customer
                    {
                        Id = 1,
                        MailAddress = "test@gmail.com",
                        CreatedDate = DateTime.Now
                    }
                );

            modelBuilder.Entity<CustomerAddress>()
              .HasData(
                  new CustomerAddress
                  {
                      Id = 1,
                      CustomerId = 1,
                      AddressName = "TEST",
                      CreatedDate = DateTime.Now
                  }
              );

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        Id = 1,
                        Code = "CODE1",
                        Price = 10,
                        Stock = 5,
                        IsActive =true,
                        CreatedDate = DateTime.Now
                    }
                );
        }
    }
}
