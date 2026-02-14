string ad, soyad;
int dogumYili;
bool cinsiyet;


//Console.WriteLine("Adınız : ");
//ad = Console.ReadLine();
//Console.WriteLine("Soyadınız : ");
//soyad = Console.ReadLine();
//Console.WriteLine("Doğum Yılınız : ");
//dogumYili = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Cinsiyetiniz (E/K) : ");
//cinsiyet = Console.ReadLine().ToLower() == "e" ? true : false;
VerileriAl();
 
void VerileriAl()
{
	Console.WriteLine("Adınız : ");
	ad = Console.ReadLine();
	Console.WriteLine("Soyadınız : ");
	soyad = Console.ReadLine();
	Console.WriteLine("Doğum Yılınız : ");
	dogumYili = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Cinsiyetiniz (E/K) : ");
	cinsiyet = Console.ReadLine().ToLower() == "e" ? true : false;
}

//Console.WriteLine("Adınız : " + ad);
//Console.WriteLine("Soyadınız : " + soyad);
//Console.WriteLine("Doğum Yılınız : " + dogumYili);

BilgileriYazdir();
BilgileriYazdir();
BilgileriYazdir();

//string gender = cinsiyet ? "Erkek" : "Kadın";
string gender = SetGender(cinsiyet);
Console.WriteLine($"Cinsiyet :  {gender}");

void BilgileriYazdir()
{
	Console.WriteLine("Adınız : " + ad);
	Console.WriteLine("Soyadınız : " + soyad);
	Console.WriteLine("Doğum Yılınız : " + dogumYili);
}

string SetGender(bool gndr)
{
	return gndr ?  "Erkek" :  "Kadın";
}

void BuyukAdYaz()
{
	Console.WriteLine(ad.ToUpper());
}

BuyukAdYaz();


void YasHesapla()
{
	int yas = DateTime.Now.Year - dogumYili;
	Console.WriteLine($"Yaşınız : {yas}");
}
YasHesapla();

int DogumYiliGuncelle(int yeniYil)
{
	dogumYili = yeniYil;
	return dogumYili;
}

int BirYasBuyut()
{
	dogumYili--;
	return dogumYili;
}

DogumYiliGuncelle(1990);
BilgileriYazdir();
BirYasBuyut();
BilgileriYazdir();

BirYasBuyut();
BilgileriYazdir();

//VerileriAl();
BilgileriYazdir();


int sayi1 = 10;
int sayi2 = 20;
int sonuc = 0;

void SonucAta(int number1, int number2)
{
	sonuc = number1 + number2;
}

SonucAta(sayi1,sayi2);
Console.WriteLine("Sonuç : " + sonuc);

SonucAta(125, 42);
Console.WriteLine("Sonuç : " + sonuc);

int SonucGetir(int number1, int number2)
{
	return number1 + number2;
}

sonuc = SonucGetir(sayi1, sayi2);
Console.WriteLine("Sonuç : " + sonuc);

Console.WriteLine("Toplam : " + SonucGetir(1200,1400));

