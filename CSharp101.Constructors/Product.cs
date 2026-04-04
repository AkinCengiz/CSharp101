using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101.Constructors;
internal class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Category { get; set; }
    public bool IsNew { get; set; }
    

    //Bu kısım ilerde anlatılacak.
    //public override string ToString()
    //{
    //    return $"Product Id : {this.Id}\nProduct Name : {this.Name}\nDescription : {this.Description}\nProduct Price : {this.Price}";
    //}
}
