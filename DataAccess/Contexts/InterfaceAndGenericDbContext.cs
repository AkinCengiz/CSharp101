using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Contexts;
public class InterfaceAndGenericDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=AKINCENGIZ;Initial Catalog=InterfaceAndGenericDb;Integrated Security=True;Trust Server Certificate=True;");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Deneme> Denemes { get; set; }
}
