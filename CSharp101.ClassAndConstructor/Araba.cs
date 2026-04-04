using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101.ClassAndConstructor;
internal class Araba
{
    public Araba()
    {
        
    }

    public Araba(string marka, string model, int yil)
    {
        Marka = marka;
        Model = model;
        Yil = yil;
    }
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Yil { get; set; }
}
