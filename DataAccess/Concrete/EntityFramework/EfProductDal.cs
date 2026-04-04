using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Contexts;
using InterfaceExample.Entity.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;
public class EfProductDal : EfGenericDal<Product>,IProductDal
{
    
    public EfProductDal(InterfaceAndGenericDbContext context) : base(context)
    {
    }
    

    public List<Product> GetAllByCategory(int categoryId)
    {
        return _context.Set<Product>().Where(product => product.CategoryId == categoryId).ToList();
    }

    public List<Product> GetAllGraterThanPrice(decimal price)
    {
        return _context.Set<Product>().Where(item => item.Price > price).ToList();
    }



}
