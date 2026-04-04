using CSharp101.Constructors;

Product product = new Product();
product.Id = 1;
product.Name = "Bilgisayar";
product.Description = "Açıklama";
product.Price = 10000;
product.Stock = 7;

Customer customer3 = new Customer();

Customer customer1 = new Customer()
{
    Address = "İstanbul",
    FirstName = "Ali",
    LastName = "Yılmaz",
    Id = 1,
    Phone = "1234567890"
};

Customer customer = new Customer("Ali", "Yılmaz");

Customer customer2 = new Customer("Akın", "Cengiz", "İstanbul");



Console.WriteLine($"Product Id : {product.Id}\nProduct Name : {product.Name}\nDescription : {product.Description}\nYeni Mi\t:{product.IsNew}");

Console.WriteLine($"Id\t:{customer.Id}\nFirstname\t: {customer.FirstName}\nLastname\t: {customer.LastName}");

Console.WriteLine($"Id\t:{customer3.Id}\nFirstname\t: {customer3.FirstName}\nLastname\t: {customer3.LastName}");
//Console.WriteLine(product);
