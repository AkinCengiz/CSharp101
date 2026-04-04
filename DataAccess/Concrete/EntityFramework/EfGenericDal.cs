using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Contexts;
using InterfaceExample.Entity.Abstract;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfGenericDal<T> :IGenericDal<T> where T : BaseEntity, new()
{
    protected readonly InterfaceAndGenericDbContext _context;
    protected readonly DbSet<T> _dbSet;

    public EfGenericDal(InterfaceAndGenericDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public void Create(T entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }

    public void Delete(T entity)
    {
        _dbSet.Remove(entity);
    }

    public T GetById(int id)
    {
        return _dbSet.Find(id);
    }

    public List<T> GetAll()
    {
        return _dbSet.Where(x => x.IsDelete == false).ToList();
    }

    public bool Any(int id)
    {
        return _dbSet.Any(t => t.Id == id);
    }
}
