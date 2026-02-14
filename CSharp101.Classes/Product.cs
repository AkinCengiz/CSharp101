using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101.Classes;
internal class Product
{
    public Product()
    {
        
    }

    public Product(string name, decimal price, int stock, int kdv)
    {
        Name = name;
        Price = price;
        Stock = stock;
        KDV = kdv;
        SetGeneralTotal();
    }
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Color { get; set; }
    public int KDV { get; set; }
    private decimal GeneralTotal { get; set; }

    public void ProductInfo()
    {
        Console.WriteLine($"{this.Name} ürününün fiyatı : {this.Price}");
    }

    private void SetPrice()
    {
        this.Price = this.Price * 100;
    }

    private void SetGeneralTotal()
    {
        GeneralTotal = Price * (1 + ((decimal)KDV / 100));
    }

    internal decimal GetGeneralTotal()
    {
        return GeneralTotal;
    }
}
