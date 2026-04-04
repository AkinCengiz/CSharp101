using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CSharp101.DbConnect;
internal class Customer
{
    private AppDbContext _context;
    private DbSet<Customer> _dbSet;

    public Customer(AppDbContext context)
    {
        _context = context;
        _dbSet = context.Set<Customer>();
    }

    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Balance { get; set; }
    public bool IsActive { get; set; }
    public string Address { get; set; }

    public void Add(Customer customer)
    {
        _dbSet.Add(customer);
        _context.SaveChanges();
    }

    public List<Customer> GetAll()
    {
        return _dbSet.ToList();
    }
}
