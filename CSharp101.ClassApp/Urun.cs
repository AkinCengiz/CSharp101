namespace CSharp101.ClassApp;

public class Urun
{
    //Varsayılan Yapıcı Metot
    public Urun()
    {

    }

    public Urun(int id)
    {
        this.Id = id;
    }

    public Urun(int id, string ad, decimal fiyat, int stok)
    {
        this.Id = id;
        this.Adi = ad;
        this.Fiyati = fiyat;
        this.Stok = stok;
    }
    public int Id { get; set; }
    public string Adi { get; set; }
    public decimal Fiyati { get; set; }
    public int Stok { get; set; }

    public void UrunBilgisi()
    {
        Console.WriteLine($"ÜRÜN BİLGİLERİ\n****************************\nID\t\t\t:{Id}\nÜrün Adı\t\t: {Adi}\nÜrün Fiyatı\t\t: {Fiyati}\nÜrün Stok Sayısı\t: {Stok}\n");
    }

    public void StokAzalt()
    {
        this.Stok--;
    }

    public void ZamYap(int oran)
    {
        this.Fiyati += this.Fiyati * (decimal) oran / 100;
    }

    public void AdGuncelle(string ad)
    {
        this.Adi = ad;
    }

    public decimal FiyatBilgisi()
    {
        return this.Fiyati;
    }
    
}