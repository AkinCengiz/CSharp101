using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Entity.Abstract;

namespace InterfaceExample.Entity.Concrete;
public sealed class Deneme : BaseEntity
{
    public string Name { get; set; }
    public bool IsThere { get; set; }
    public int Age { get; set; }
}
