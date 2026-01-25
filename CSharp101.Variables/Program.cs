namespace CSharp101.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Değişkenler
            //ValueTypes - Değer Tipleri
            //Sayısal Tam sayı değerlerini tutan veri tipleri
            //Btye => 0 - 255 arasında değer alır. 0000 0010 => (0 * 2^3 + 0 * 2^2 + 1 * 2^1 + 0 * 2^0)
            //sbyte => -128 ile 127 arası değerler alır
            //short => -32768 ile 32767 arası değer alır
            //ushort => 0 ile 65535 arası değer alır
            //int => -2147483648 ile 2147483647
            //uint => 0 ile 4294967295

            //Değişken oluşturma kuralları
            //değişkenintürü değişkeneverilecekisim;
            

            //camelCase => Değişken ismi birden fazla kelimeden oluşuyorsa yani adSoyad, dogumTarihi, toplamOdenecekTutar ,firstName, lastName, birthDate ilk kelimenin ilk harfi küçük sonra gelen her kelimenin ilk harfi büyük olacak şekilde

            //PascalCase => Değişken ismi birden fazla kelimeden oluşuyorsa AdSoyad, DogumTarihi, ToplamOdenecekTutar ,FirstName, LastName, BirthDate her kelimenin ilk harfi büyük olacak şekilde

            //Snake_Case => Değişken ismi birden fazla kelimeden oluşuyorsa ad_soyad, dogum_tarihi, toplam_odenecek_tutar ,first_name, last_name, birth_date her kelimenin ilk harfi büyük olacak şekilde
            //
            //Kebap-Case => Değişken ismi birden fazla kelimeden oluşuyorsa ad-soyad, dogum-tarihi, toplam-odenecek-tutar ,first-name, last-name, birth-date her kelimenin ilk harfi büyük olacak şekilde,


            //DEĞER TİPLERİ
            byte yas = 16;
            byte numara = 32;
            byte minByte = byte.MinValue;
            byte maxByte = byte.MaxValue;

            Console.WriteLine("*******************************");
            Console.WriteLine("Değişken : {0}\nMinimum : {1}\nMaksimum : {2}",yas,minByte,maxByte);
            Console.WriteLine($"Değişken : {yas}\nMinimum : {minByte}\nMaksimum : {maxByte}");

            sbyte degree = -65;
            sbyte minSbyte = sbyte.MinValue;
            sbyte maxSbyte = sbyte.MaxValue;
            Console.WriteLine("*******************************");
            Console.WriteLine("Değişken : {0}\nMinimum : {1}\nMaksimum : {2}", degree, minSbyte, maxSbyte);

            short number1 = -1658;
            short minShort = short.MinValue;
            short maxShort = short.MaxValue;
            Console.WriteLine("*******************************");
            Console.WriteLine("Değişken : {0}\nMinimum : {1}\nMaksimum : {2}", number1, minShort, maxShort);

            ushort number2 = 1658;
            ushort minUShort = ushort.MinValue;
            ushort maxUShort = ushort.MaxValue;
            Console.WriteLine("*******************************");
            Console.WriteLine("Değişken : {0}\nMinimum : {1}\nMaksimum : {2}", number2, minUShort, maxUShort);

            int population = 80000000;
            int minInt = int.MinValue;
            int maxInt = int.MaxValue;
            Console.WriteLine("*******************************");
            Console.WriteLine("Değişken : {0}\nMinimum : {1}\nMaksimum : {2}", population, minInt, maxInt);

            uint worldPolulation = 600000000;
            uint minUint = uint.MinValue;
            uint maxUint = uint.MaxValue;
            Console.WriteLine("*******************************");
            Console.WriteLine("Değişken : {0}\nMinimum : {1}\nMaksimum : {2}", worldPolulation, minUint, maxUint);

            long bigNumber = 8452314569875388633;
            long minLong = long.MinValue;
            long maxLong = long.MaxValue;
            Console.WriteLine("*******************************");
            Console.WriteLine("Değişken : {0}\nMinimum : {1}\nMaksimum : {2}", bigNumber, minLong, maxLong);

            //byte 2^7
            // int (2^7)^2
            //long((2^7)^2)^2

            //float, double ve decimal 8,25 1.564.258,25 == 1,564,258.25

            float gram = 5.824f;
            double gram2 = 9.12546;
            decimal gram3 = 9.1256387m;

            Console.WriteLine("*******************************");
            Console.WriteLine("Değişken : {0}\nMinimum : {1}\nMaksimum : {2}", gram, float.MinValue, float.MaxValue);
            Console.WriteLine("*******************************");
            Console.WriteLine("Değişken : {0}\nMinimum : {1}\nMaksimum : {2}", gram2, double.MinValue, double.MaxValue);
            Console.WriteLine("*******************************");
            Console.WriteLine("Değişken : {0}\nMinimum : {1}\nMaksimum : {2}", gram3, decimal.MinValue, decimal.MaxValue);

            bool varMi = false;
            bool dogruMu = true;
            bool yokMu = true; //Değişken isimlendirmesi olumlu olarak oluşturulmalı.

            Console.WriteLine(varMi + " " + dogruMu);

            char karakter1 = 'a';
            char karakter2 = 'A';
            Console.WriteLine((int)karakter1 + "\n" + (int)karakter2);

            //REFERANS TİPLER
            //String, object, sınıflar ve struct, array

            string name = "Akın";
            string lastname = "Cengiz";

            int sayi1 = 5;
            int sayi2 = sayi1;

            sayi2 = sayi2 + 23;//28
            sayi1 = 98;
            Console.WriteLine($"Sayı 1 = {sayi1}\nSayı 2 = {sayi2}");

            int[] numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var item in numbers)
            {
                Console.WriteLine("Numbers dizisi : " + item);
            }

            int[] numbers2 = numbers;
            foreach (var i in numbers2)
            {
                Console.WriteLine("Numbers2 dizisi : " + i);
            }

            numbers[5] = 34;
            numbers[0] = 67;
            numbers[3] = 129;

            Console.WriteLine("*****************************");
            Console.WriteLine("1: DÖNGÜ");

            foreach (var item in numbers)
            {
                Console.WriteLine("Numbers dizisi : " + item);
            }
            Console.WriteLine("2: DÖNGÜ");
            foreach (var i in numbers2)
            {
                Console.WriteLine("Numbers2 dizisi : " + i);
            }
        }
    }
}
