using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Contexts;
using InterfaceExample.Entity.Concrete;

namespace DataAccess.Concrete.EntityFramework;
public class EfDenemeDal : EfGenericDal<Deneme>
{
    public EfDenemeDal(InterfaceAndGenericDbContext context) : base(context)
    {
    }
}
