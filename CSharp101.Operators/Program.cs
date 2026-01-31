//OPERATÖRLER
//Aritmetiksel Operatörler
// + : Toplama, - : Çıkarma, * : Çarpma, / : Bölme, % : Mod alma

using System.ComponentModel;

int number1 = 10;
int number2 = 3;

int toplam = number1 + number2; // Toplama
int fark = number1 - number2;   // Çıkarma
int carpim = number1 * number2; // Çarpma
double bolum = (double)number1 / number2; // Bölme
double blm = Convert.ToDouble(number1) / number2; // Bölme
double bolum2 = number1 / number2; // Bölme
int mod = number1 % number2; // Mod alma

Console.WriteLine("Toplam : " + toplam);
Console.WriteLine("Fark : " + fark);
Console.WriteLine("Çarpım : " + carpim);
Console.WriteLine("Bölüm : " + bolum);
Console.WriteLine("Int Bolüm : " + bolum2);
Console.WriteLine("Int Cnvrt Bolüm : " + blm);
Console.WriteLine("Mod : " + mod);

byte byteNumber = 25;
double doubleNumber = (double)byteNumber; // Tür dönüşümü ile genişletme
int intNumber = (int)doubleNumber; // Tür dönüşümü ile daraltma

//Atama Operatörleri
// = : Atama, += : Toplama ve atama, -= : Çıkarma ve atama

int a = 5; // = Sağdaki değeri soldaki değişkene atar
int b = a;

a += 3; // a = a + 3 ile aynı
b = b + 4;
b += 7; // b = b + 7 ile aynı

b = b - 2;
b -= 5; // b = b - 5 ile aynı

a = a * 2;

a *= 3; // a = a * 3 ile aynı

a = a / 2;

a /= 3; // a = a / 3 ile aynı

a %= 5; // a = a % 5 ile aynı

//3+7-(5*4)+(9/2)

Console.WriteLine("A = " + a);

//Karşılaştırma Operatörleri
// == : Eşit mi, != : Eşit değil mi, > : Büyük mü, < : Küçük mü, >= : Büyük veya eşit mi, <= : Küçük veya eşit mi

a = 4;
b = 7;
int c = 7;

bool esitMi = (a == b); // false
Console.WriteLine("A B ye eşit mi? :" + esitMi);
esitMi = (b == c); // true
Console.WriteLine("C B ye eşit mi? :" + esitMi);

bool esitDegilMi = (a != b); // true
Console.WriteLine("A B ye eşit değil mi? :" + esitDegilMi);
esitDegilMi = (b != c); // false
Console.WriteLine("C B ye eşit değil mi? :" + esitDegilMi);

bool buyukMu = (a > b); // false
Console.WriteLine("A B den büyük mü? :" + buyukMu);
buyukMu = (c > b); // false
Console.WriteLine("C B den büyük mü? :" + buyukMu);
buyukMu = (b > a); // true
Console.WriteLine("B A dan büyük mü? :" + buyukMu);

bool kucukMu = (a < b); // true
Console.WriteLine("A B den küçük mü? :" + kucukMu);
kucukMu = (c < b); // false
Console.WriteLine("C B den küçük mü? :" + kucukMu);
kucukMu = (b < a); // false
Console.WriteLine("B A dan küçük mü? :" + kucukMu);

bool buyukEsitMi = (a >= b); // false
Console.WriteLine("A B den büyük veya eşit mi? :" + buyukEsitMi);
buyukEsitMi = (c >= b); // true
Console.WriteLine("C B den büyük veya eşit mi? :" + buyukEsitMi);
buyukEsitMi = (b >= a); // true
Console.WriteLine("B A dan büyük veya eşit mi? :" + buyukEsitMi);

bool kucukEsitMi = (a <= b); // true
Console.WriteLine("A B den küçük veya eşit mi? :" + kucukEsitMi);
kucukEsitMi = (c <= b); // true
Console.WriteLine("C B den küçük veya eşit mi? :" + kucukEsitMi);
kucukEsitMi = (b <= a); // false
Console.WriteLine("B A dan küçük veya eşit mi? :" + kucukEsitMi);

//Mantıksal Operatörler
// && : Ve, || : Veya, ! : Değil

int x = 5;
int y = 10;
int z = 15;
int t = 10;
bool sonuc;

sonuc = (x < y) && (y < z);
//        true  &&  true -> true
// Ve işlemi için her iki ifadenin de doğru olması gerekir. Ve işleminde bir ifade yanlış ise sonuç yanlış olur.
sonuc = (x < y) && (y > z) && (t < z);

Console.WriteLine("Sonuç : " + sonuc);