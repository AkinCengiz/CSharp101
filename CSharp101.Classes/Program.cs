using CSharp101.Classes;

Product product = new Product();
product.Name = "Cep Telefonu";
product.Stock = 15;
product.Price = 2500m;
product.Id = 1;
product.Color = "Beyaz";

product.ProductInfo();
Console.WriteLine(product.GetGeneralTotal());

Product product2 = new Product("TV", 5000, 7, 18);
product2.ProductInfo();
Console.WriteLine($"Genel Toplam : {product2.GetGeneralTotal()}");