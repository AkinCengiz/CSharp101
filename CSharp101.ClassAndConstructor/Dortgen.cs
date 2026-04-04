using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharp101.ClassAndConstructor;
internal class Dortgen
{
    private int _kisaKenar;
    private int _uzunKenar;
    //private string _name;
    //private decimal _fiyat;



    public int KisaKenar
    {
        get
        {
            return _kisaKenar;
        }
        set
        {
            if (value < 0)
            {
                _kisaKenar = 0;
            }
            else
            {
                _kisaKenar = value;
            }
        }
    }

    public int UzunKenar
    {
        get
        {
            return _uzunKenar;
        }
        set
        {
            if (value < 0)
            {
                _uzunKenar = 0;
            }
            else
            {
                _uzunKenar = value;
            }
        }
    }

    public void AlanYazdir()
    {
        Console.WriteLine($"Dörtgenin Alanı\t: { ALanHesapla() } br2");
    }

    public int ALanHesapla()
    {
        return UzunKenar * KisaKenar;
    }

    public void CevreYazdir()
    {
        Console.WriteLine("Dörtgenin çevresi : " + CevreHesapla());
    }

    public int CevreHesapla()
    {
        return (_uzunKenar + _kisaKenar) * 2;
    }

    void KenarDegistir(int kisaKenar, int uzunKenar)
    {
        this._uzunKenar = uzunKenar;
        this._kisaKenar = kisaKenar;
    }

   
    
    
    
    
    
    
    
    
    
    
    //public string Name
    //{
    //    get
    //    {
    //        return "Sayın " + _name;
    //    } set
    //    {
    //        _name = value;
    //    }
    //}

    //public decimal Fiyat
    //{
    //    get
    //    {
    //        return _fiyat + (_fiyat * 10 / 100);
    //    } set
    //    {
    //        _fiyat = value;
    //    }
    //}


    
    
    
    
    
    
    //FAKTORİYEL ÜZERİNDEN ÖZYİNELEMELİ METOT KONUSU ANLATILDI.
    public int Faktoriyel(int sayi)
    {
        int sonuc = 1;
        for (int i = sayi; i > 1; i--)
        {
            sonuc *= i;
        }
        return sonuc;
    }

    public int OzyinelemeliFaktoriyel(int sayi)
    {
        if (sayi == 1)
        {
            return 1;
        }

        return sayi * OzyinelemeliFaktoriyel(sayi-1);
    }

    
}
