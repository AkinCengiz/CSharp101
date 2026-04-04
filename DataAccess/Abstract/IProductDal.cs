using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Entity.Concrete;

namespace DataAccess.Abstract;
public interface IProductDal : IGenericDal<Product>
{
    List<Product> GetAllByCategory(int categoryId);
    List<Product> GetAllGraterThanPrice(decimal price);
}
