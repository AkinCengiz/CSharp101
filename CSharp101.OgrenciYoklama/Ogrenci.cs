using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101.OgrenciYoklama;
internal class Ogrenci
{
    public int Numara { get; set; }
    public string AdSoyad { get; set; }
    public bool MevcutMu { get; set; }

    public Ogrenci(int numara, string adSoyad, bool mevcutMu)
    {
        Numara = numara;
        AdSoyad = adSoyad;
        MevcutMu = mevcutMu;
    }

    public Ogrenci()
    {
        
    }
}
