using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Abstract;
using InterfaceAndGeneric.Business.Abstract;
using InterfaceExample.Entity.Concrete;

namespace InterfaceAndGeneric.Business.Concrete;
public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public void Create(Category entity)
    {
        
        _categoryDal.Create(entity);
    }

    public void Update(Category entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Category entity)
    {
        throw new NotImplementedException();
    }

    public Category GetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<Category> GetAll()
    {
        throw new NotImplementedException();
    }
}
