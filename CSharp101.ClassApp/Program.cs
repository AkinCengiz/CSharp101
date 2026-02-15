
using CSharp101.ClassApp;

Urun urun = new Urun();
urun.UrunBilgisi();
urun.Id = 1;
urun.Adi = "Cep Telefonu";
urun.Fiyati = 5000;
urun.Stok = 25;

Urun urun2 = new Urun(3)
{
    Id = 2,
    Adi = "Televizyon",
    Fiyati = 7500,
    Stok = 12
};
Urun urun3 = new Urun(10, "Araba", 35000, 3);

urun2.UrunBilgisi();
urun.UrunBilgisi();

urun.ZamYap(10);
urun2.StokAzalt();
urun2.UrunBilgisi();
urun.UrunBilgisi();

Kategori kategori = new Kategori
{
    Id = 1,
    Adi = "Teknoloji"
};

kategori.GetKategori();

decimal mesaj = urun.FiyatBilgisi();
Bos bos = new Bos();

urun3.UrunBilgisi();