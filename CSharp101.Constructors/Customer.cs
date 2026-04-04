using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101.Constructors;
internal class Customer
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }

    public Customer(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public Customer(string firstName, string lastName, string address)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Address = address;
    }

    public Customer()
    {
        this.Address = "Adres girilmemiş...";
        this.FirstName = "İsim girilmemiş";
        this.LastName = "Soyisim girilmemiş";
        this.Id = 0;
        this.Phone = "00000000000";
    }
}
