using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceExample.Entity.Abstract;

namespace InterfaceExample.Entity.Concrete;
public  class Product : BaseEntity
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public int CategoryId { get; set; } // İlişki Kolonu
    public Category Category { get; set; } //Navigation Property
    
}
