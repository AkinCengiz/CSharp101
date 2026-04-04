using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CSharp101.DbConnect;
internal class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=AKINCENGIZ;Initial Catalog=MusteriYonetimDb;Integrated Security=True;Trust Server Certificate=True;");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(p => p.Property(p => p.Name).HasMaxLength(50).IsRequired());
        modelBuilder.Entity<Product>(p => p.HasData(
            new Product() { Id = 1, Name = "Cep Telefonu", Price = 15000, Stock = 15 },
            new Product() { Id = 2, Name = "Bilgisayar", Price = 23000, Stock = 15 },
            new Product() { Id = 3, Name = "Televizyon", Price = 22000, Stock = 15 },
            new Product() { Id = 4, Name = "Mobilya", Price = 15000, Stock = 15 },
            new Product() { Id = 5, Name = "Buzdolabı", Price = 15000, Stock = 15 }
        ));
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
}
