// See https://aka.ms/new-console-template for more information

using CSharp101.DbConnect;
using Microsoft.EntityFrameworkCore.Migrations.Operations;



Customer customer = new Customer(new AppDbContext());
//customer.FirstName = "Erkan";
//customer.LastName = "Günay";
//customer.Balance = 10000;
//customer.IsActive = true;
//customer.Address = "İstanbul";

//customer.Add(customer);
Console.Write("Müşteri Adı Giriniz :");
customer.FirstName = Console.ReadLine();
Console.Write("Müşteri Soyadı Giriniz :");
customer.LastName = Console.ReadLine();

Console.Write("Müşteri Bakiyesi Giriniz :");
customer.Balance = Convert.ToDecimal(Console.ReadLine());

Console.Write("Müşteri Adresi Giriniz :");
customer.Address = Console.ReadLine();
customer.IsActive = true;

customer.Add(customer);

var list = customer.GetAll();
foreach (var item in list)
{
    Console.WriteLine($"{item.FirstName} {item.LastName}");
}