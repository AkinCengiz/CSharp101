using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrame;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Contexts;
using InterfaceAndGeneric.Business.Abstract;
using InterfaceExample.Entity.Concrete;

namespace InterfaceAndGeneric.Business.Concrete;
public class ProductManager : IProductService
{
    private readonly IProductDal _productDal;

    public ProductManager(IProductDal productDal)
    {
        _productDal = new EfProductDal(new InterfaceAndGenericDbContext());
    }

    public void Create(Product entity)
    {
        _productDal.Create(entity);
    }

    public void Update(Product entity)//Name => Samsung = IPhone, Price : 25000 = 35000, Stock : 15 = 12, UpdateAt = null : 04.04.2026
    {
        entity.UpdateAt = DateTime.Now;
        _productDal.Update(entity);
    }

    public void Delete(Product entity)
    {
        //entity.IsActive = false;
        //entity.IsDelete = true;
        //entity.UpdateAt = DateTime.Now;
        //_productDal.Update(entity);
        _productDal.Delete(entity);
    }

    public Product GetById(int id)
    {
        return _productDal.GetById(id);
    }

    public List<Product> GetAll()
    {
        return _productDal.GetAll();
    }
}
