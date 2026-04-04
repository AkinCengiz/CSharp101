
using CSharp101.OgrenciYoklama;

List<Ogrenci> ogrenciler = new List<Ogrenci>();


Ogrenci ogrenci = new Ogrenci();
ogrenci.Numara = 5;
ogrenci.AdSoyad = "Ahmet Yılmaz";
ogrenci.MevcutMu = true;
ogrenciler.Add(ogrenci);

Ogrenci ogrenci1 = new Ogrenci(){ Numara = 6,AdSoyad = "Ayşe Güneş", MevcutMu = false};
ogrenciler.Add(ogrenci1);

Ogrenci ogrenci2 = new Ogrenci(11,"Mehmet Uzun",true);
ogrenciler.Add(ogrenci2);

ogrenciler.Add(new Ogrenci(23,"Fatma Altın",true));
ogrenciler.Add(new Ogrenci(24,"Hasan Şahin",false));
ogrenciler.Add(new Ogrenci(25,"Aycan Gümüş",true));
ogrenciler.Add(new Ogrenci(26,"Mehmet Aslan",false));
ogrenciler.Add(new Ogrenci(27,"Selim Erdal",true));
ogrenciler.Add(new Ogrenci(28,"Ebru Cömert",true));
ogrenciler.Add(new Ogrenci(29,"Muhammed Saka",true));
ogrenciler.Add(new Ogrenci(30,"Erkan Günay",true));

int secenek;
bool devamMi = true;

Console.WriteLine("Öğrenci Yoklama Sistemine Hoş Geldiniz!\n\n");

while (devamMi)
{
   secenek = AcilisEkrani();
   

    switch (secenek)
    {
        case 1:
            OgrencileriListele(ogrenciler);
            Console.ReadLine();
            break;
        case 2:
            OgrencileriDurumaGoreGetir(ogrenciler,true);
            Console.ReadLine();
            break;
        case 3:
            OgrencileriDurumaGoreGetir(ogrenciler, false);
            Console.ReadLine();
            break;
        case 4:
            Console.Write("Öğrenci Numarası Girin : ");
            int num = Convert.ToInt32(Console.ReadLine());
            OgrenciGetir(ogrenciler,num);
            Console.ReadLine();
            break;
        case 5:
            devamMi = false;
            Console.WriteLine("Güle güle");
            Console.ReadLine();
            break;
        default:
            Console.WriteLine("Hatalı seçim");
            Console.ReadLine();
            break;
    }
}

static void OgrenciGetir(List<Ogrenci> ogrenciListesi, int ogrenciNo)
{
    //Öğrenci nesne oluşturduk. New yapmadan hazır new areferansı verdik.
    Ogrenci ogrenci = ogrenciListesi.Where(o => o.Numara == ogrenciNo).FirstOrDefault();
    if (ogrenci != null)
    {
        Console.WriteLine("\n================= ÖĞRENCİ BİLGİLERİ===================\n");
        Console.WriteLine("No\t\tAdı Soyadı\t\tSınıfta Mı");
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("{0,5}\t\t{1,-20}\t{2,-6}", ogrenci.Numara, ogrenci.AdSoyad, ogrenci.MevcutMu ? "Mevcut" : "Değil");
    }
    else
    {
        Console.WriteLine("Bu numaralı öğrenci bulunamadı...");
    }
}
static void OgrencileriListele(List<Ogrenci> ogrenciList)
{
    Console.WriteLine("\n=================GENEL ÖĞRENCİ LİSTESİ===================\n");
    Console.WriteLine("No\t\tAdı Soyadı\t\tSınıfta Mı");
    Console.WriteLine("---------------------------------------------------");
    foreach (var ogrenci in ogrenciList)
    {
        Console.WriteLine("{0,5}\t\t{1,-20}\t{2,-6}",ogrenci.Numara,ogrenci.AdSoyad,ogrenci.MevcutMu?"Mevcut":"Değil");
    }
}

static void OgrencileriDurumaGoreGetir(List<Ogrenci> ogrenciListesi, bool durum)
{
    if (durum)
    {
        Console.WriteLine("\n=============== MEVCUT ÖĞRENCİLER LİSTESİ ================\n");
    }
    else
    {
        Console.WriteLine("\n============ MEVCUT OLMAYAN ÖĞRENCİLER LİSTESİ =============\n");
    }
    Console.WriteLine("No\t\tAdı Soyadı\t\tSınıfta Mı");
    Console.WriteLine("---------------------------------------------------");

    List<Ogrenci> ogrList = ogrenciListesi.Where(o => o.MevcutMu == durum).ToList();

    foreach (var ogrenci in ogrList)
    {
        Console.WriteLine("{0,5}\t\t{1,-20}\t{2,-6}", ogrenci.Numara, ogrenci.AdSoyad, ogrenci.MevcutMu ? "Mevcut" : "Değil");
    }

}

static int AcilisEkrani()
{
    //Console.Clear();
    Console.WriteLine("Yapmak istediğiniz işlemi seçin\n====================================");
    Console.WriteLine("Öğrenci Listesi İçin\t\t=> 1");
    Console.WriteLine("Yoklama Listesi İçin\t\t=> 2");
    Console.WriteLine("Gelmeyenler Listesi İçin\t=> 3");
    Console.WriteLine("Öğrenci Seçmek İçin\t\t=> 4");
    Console.WriteLine("Çıkış İçin\t\t\t=> 5\n====================================");
    Console.Write("Seçiminiz : ");

    int deger;
    string secim = Console.ReadLine();

    if (!int.TryParse(secim, out deger))
    {
        return 1;
    }

    return deger;
}