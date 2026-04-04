
using CSharp101.ClassAndConstructor;


//Constructor metodu new anahtar kelimesi yazılınca çalışır.
//Product product3 = new Product(1, "3. Product");
//Product product1 = new Product();
//Product product2 = new Product("Deneme");
//Product product4 = new Product(10000);

//product1.Name = "Bilgisayar";
//product1.Description = "i7 Core işlemcili";
//product1.Id = 1;
//Console.WriteLine("Price 1: " + product1.Price);
//Console.WriteLine("Price 2: " + product2.Price);
//Console.WriteLine("Price 3: " + product3.Price);
//Console.WriteLine("Price 4: " + product4.Price);

//Dortgen dortgen = new Dortgen();
//dortgen.KisaKenar = -15;
//Console.WriteLine("Kısa Kenar : " + dortgen.KisaKenar);

//dortgen.Name = "Kare";
//Console.WriteLine(dortgen.Name);
//dortgen.Name = "Deneme";
//Console.WriteLine(dortgen.Name);
//dortgen.Fiyat = 10000;
//Console.WriteLine("Fiyat : " + dortgen.Fiyat);
//int SayiVer()
//{
//    return 5;
//}
//int degisken = SayiVer();
//Console.WriteLine(degisken);
//Console.WriteLine("YENİ SATIR");


//Console.WriteLine("3 Faktoriyel =" + dortgen.Faktoriyel(5));
//Console.WriteLine("3! Faktoriyel =" + dortgen.OzyinelemeliFaktoriyel(5));

//Dortgen d1 = new Dortgen();
//d1.KisaKenar = 5;
//d1.UzunKenar = 10;
//d1.AlanYazdir();
//d1.CevreYazdir();

Araba[] arabalar = new Araba[4];

List<Ogrenci> ogrenciler = new List<Ogrenci>();

arabalar[0] = new Araba(){Marka = "Pegout",Model = "3008",Yil = 2020};

Araba araba = new Araba();
araba.Marka = "Mercedes";
araba.Model = "S600";
araba.Yil = 2026;
arabalar[1] = araba;

arabalar[2] = new Araba("Toyota","Corolla",2025);

Araba benimArabam = new Araba("Toyota","Corolla",2025);

arabalar[3] = benimArabam;

foreach (var item in arabalar)
{
    Console.WriteLine($"{item.Marka} - {item.Model} arabanın Modeli {item.Yil}");
}


ogrenciler.Add(new Ogrenci(){Firstname = "Muhammed",Lastname = "Saka",Number ="1903"});
ogrenciler.Add(new Ogrenci("Erkan","Günay","1907"));
foreach (var ogr in ogrenciler)
{
    Console.WriteLine($"Öğrenci Adı\t: {ogr.Firstname} \t Soyadı\t:{ogr.Lastname}");
}

Console.WriteLine(araba.Model);
Console.WriteLine(arabalar[1].Model);
Console.WriteLine(arabalar[3].Yil);
Console.WriteLine(benimArabam.Yil);

void SayılarıGeriYazdırma(int sayi)
{
    if (sayi < 0)
    {
        return;//f(-1)
    }
    else
    {
        Console.WriteLine("F({0}) => f({1})",sayi,sayi-1);
        SayılarıGeriYazdırma(sayi - 1); //f4(5-1) === f3(4-1) ===  f2(3-1) ===  f1(2-1) === f0(1-1) === f-1(0-1)
        Console.WriteLine(sayi); //0 1 2 3 4 5
    }
}

SayılarıGeriYazdırma(5);//Metodu Çağırdım

int SayiVer()
{
    Random rnd = new Random();
    return rnd.Next(1, 11);
}

int sayi1 = SayiVer();//5
int sayiBir = 5;
int sayi2 = SayiVer();//7
int sayi3 = SayiVer();
Console.WriteLine("{0},{1},{2}",sayi1,sayi2,sayi3);