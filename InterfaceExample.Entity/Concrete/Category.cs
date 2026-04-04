using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Entity.Abstract;

namespace InterfaceExample.Entity.Concrete;
public sealed class Category : BaseEntity
{
    public string Name { get; set; }
    public List<Product> Products { get; set; }//Navigation Property
}
