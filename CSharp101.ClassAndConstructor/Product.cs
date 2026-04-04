using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101.ClassAndConstructor;
internal class Product
{
    public Product()
    {
        Price = 1500;
        Console.WriteLine("Varsayılan yapıcı metot");
    }

    public Product(string name)
    {
        Price = 2000;
        Console.WriteLine("Name parametreli yapıcı metot");
    }

    public Product(int id, string name)
    {
        Price = 3000;
        Console.WriteLine("Id ve name parametreli yapıcı metot");
    }

    public Product(decimal price)
    {
        Price = price;
    }


    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; }


}
