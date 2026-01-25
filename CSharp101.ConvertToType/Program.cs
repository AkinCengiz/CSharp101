// See https://aka.ms/new-console-template for more information

using System.Threading.Channels;
using System.Xml.Linq;

//int sayi1 = 15;
//string name = "Akın";

//{
//    int sayi2 = 34;
//    string name2 = "Erkan";
//    Console.WriteLine("Scope1--------------");
//    Console.WriteLine($"Sayi 1 : {sayi1}\nİsim : {name}");
//    Console.WriteLine($"Sayi 2 : {sayi2}\nİsim2 : {name2}");
//    {
//        int sayi4 = 4;
//        string name4 = "Name4";
//        Console.WriteLine("Scope1 İçindeki Scope--------------");
//        Console.WriteLine($"Sayi 1 : {sayi1}\nİsim : {name}");
//        Console.WriteLine($"Sayi 2 : {sayi2}\nİsim2 : {name2}");
//        Console.WriteLine($"Sayi 4 : {sayi4}\nİsim4 : {name4}");
//    }
//}

//{
//    int sayi3 = 22;
//    string name3 = "Muhammed";
//    Console.WriteLine("Scope2--------------");
//    Console.WriteLine($"Sayi 1 : {sayi1}\nİsim : {name}");
//    Console.WriteLine($"Sayi 2 : {sayi3}\nİsim2 : {name3}");
//}

//Console.WriteLine($"Sayi 1 : {sayi1}\nİsim : {name}");


//Kullanıcıdan toplam sonucunu vermek için 2 adet sayı girmesi istenecek.
//Sonra kullanıcının verdiği sayılar toplanarak sonuç kullancıya gösterilecek.
//int sayi1,sayi2,toplam=0;

//Console.Write("1. Sayıyı Giriniz\t: ");

////Değişkenlerde tür dönüşümü işlemleri yapmak için Convert Sınıfının metotları kullanılır.
//sayi1 = Convert.ToInt32(Console.ReadLine());
////Console.WriteLine("Sayı 1 : " + sayi1);

//Console.Write("2. Sayıyı Giriniz : ");
//sayi2 = Convert.ToInt32(Console.ReadLine());
////sayi2 = Console.ReadLine();
//toplam = sayi1 + sayi2;

//Console.WriteLine($"{sayi1} + {sayi2} = {toplam}");

Console.WriteLine("İsim\t\t:\nSoyisim\t\t: \nYaş\t\t: \nCinsiyet\t:");
Console.WriteLine("Yaşadığım\\ şehir \"İstanbul\"");
Console.WriteLine("Göktürk Merkez Mh. 2. Çayır Sk. No:8 Eyüp\\İST");
Console.WriteLine("C:\\Users\\akinc\\AppData\\Local\\Microsoft\\Microsoft SQL Server Local DB\\Instances\\MSSQLLocalDB");
Console.WriteLine("Akın\'ın");

Console.WriteLine("1. Sıra\t:\n2. Sıra\t\r3.:");
//"2. Sıra\t\r3.: "

//Convert Sınıfı ile tür dönüşümleri
//ConvertToBoolean(değişken); değişkeni bool türüne çevirir
//ConvertToByte(değişken); değişkeni byte türüne çevirir
//ConvertToSByte(değişken); değişkeni sbyte türüne çevirir
//ConvertToUInt16(değişken); değişkeni ushort türüne çevirir
//ConvertToInt32(değişken); değişkeni int türüne çevirir
//ConvertToUInt32(değişken); değişkeni uint türüne çevirir
//ConvertToInt64(değişken); değişkeni long türüne çevirir
//ConvertToUInt64(değişken); değişkeni ulong türüne çevirir
//ConvertToSingle(değişken); değişkeni float türüne çevirir
//ConvertToDouble(değişken); değişkeni double türüne çevirir
//ConvertToDecimal(değişken); değişkeni decimal türüne çevirir

int number = Convert.ToInt32("32");
int number2 = Convert.ToInt32("23");
Console.WriteLine("Int number değişkeni : " + number);


string sayi1, sayi2;
int toplam = 0;
int carpim = 1;

Console.Write("1. Sayıyı Giriniz\t: ");

//Değişkenlerde tür dönüşümü işlemleri yapmak için Convert Sınıfının metotları kullanılır.
sayi1 = Console.ReadLine();
//Console.WriteLine("Sayı 1 : " + sayi1);

Console.Write("2. Sayıyı Giriniz : ");
sayi2 = Console.ReadLine();

int number1 = Convert.ToInt32(sayi1);
int number3 =Convert.ToInt32(sayi2);

toplam = Convert.ToInt32(sayi1) + Convert.ToInt32(sayi2);
carpim = Convert.ToInt32(sayi1) * Convert.ToInt32(sayi2);
toplam = number1 + number3;
carpim = number1 * number3;
Console.WriteLine($"{sayi1} + {sayi2} = {toplam}");
Console.WriteLine($"{sayi1} * {sayi2} = {toplam}");