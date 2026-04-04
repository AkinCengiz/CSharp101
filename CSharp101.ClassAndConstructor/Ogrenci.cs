using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101.ClassAndConstructor;
internal class Ogrenci
{
    public Ogrenci()
    {
        
    }

    public Ogrenci(string firstname, string lastname, string number)
    {
     Firstname = firstname;
     Lastname = lastname;
     Number = number;
    }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Number { get; set; }
}
