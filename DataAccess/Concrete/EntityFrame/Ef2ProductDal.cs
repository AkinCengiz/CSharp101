using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using InterfaceExample.Entity.Concrete;

namespace DataAccess.Concrete.EntityFrame;
public class Ef2ProductDal : IProductDal
{
    public void Create(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Update(Product entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Product entity)
    {
        throw new NotImplementedException();
    }

    public Product GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAll()
    {
        throw new NotImplementedException();
    }

    public bool Any(int id)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAllByCategory(int categoryId)
    {
        throw new NotImplementedException();
    }

    public List<Product> GetAllGraterThanPrice(decimal price)
    {
        throw new NotImplementedException();
    }
}
