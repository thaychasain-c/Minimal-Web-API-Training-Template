using System;
using Microsoft.EntityFrameworkCore;
using Web_API_Training_Template.Models;

namespace Web_API_Training_Template
{
	public partial class NorthwindDB : DbContext
    {
		public NorthwindDB(DbContextOptions options) : base(options) { }

        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Employee> Employees { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Shipper> Shippers { get; set; } = null!;
        public DbSet<Supplier> Suppliers { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(NorthwindDB).Assembly);
            //modelBuilder.Enti().Configure(e => e.SetTableName(e.ClrType.Name.ToLowercaseNamingConvention()));
            //modelBuilder.EntityTypes().Configure(e => e.SetSchema(e.GetSchema().ToLowercaseNamingConvention()));
            //modelBuilder.Properties().Configure(p => p.SetColumnName(p.Name.ToLowercaseNamingConvention()));
        }
    }
}

