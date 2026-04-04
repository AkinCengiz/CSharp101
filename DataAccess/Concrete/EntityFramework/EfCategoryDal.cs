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
public class EfCategoryDal : EfGenericDal<Category>,ICategoryDal
{
    public EfCategoryDal(InterfaceAndGenericDbContext context) : base(context)
    {
    }
}
