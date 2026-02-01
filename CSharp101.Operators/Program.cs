//OPERATÖRLER
//Aritmetiksel Operatörler
//Binary operators
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


int vize1 = 75;
int vize2 = 85;
int final = 55;

double ortalama = (vize1 + vize2) / 2 * 0.4 + final * 0.6;

sonuc = (ortalama >= 60) && (final >= 50);
//a < b && c < d && e < f && ... gibi uzatılabilir. Bir den fazla koşulun aynı anda sağlanması gerektiğinde kullanılır. Bir tanesi bile sağlanmazsa sonuç false olur.
//a < b || c < d || e < f || ... gibi uzatılabilir. Bir koşulun sağlanması yeterlidir. Tüm koşullar false ise sonuç false olur.

//ternary operator (üçlü operatör)
// koşul ? doğru ise yapılacak işlem : yanlış ise yapılacak işlem

string gectiMi = sonuc ? "Geçti" : "Kaldı";

//!Değil operatörü
bool deneme = !(x < z) ? true : false;

Console.WriteLine("Ortalama : " + ortalama +"\nSonuç : " + gectiMi);

Console.WriteLine($"x : {x} < {z} mi?");
Console.WriteLine("Deneme : " + deneme);


int gün = 12;

// 0 : Pazartesi, 1 : Salı, 2 : Çarşamba, 3 : Perşembe, 4 : Cuma, 5 : Cumartesi, 6 : Pazar
string haftaSonu = !((gün % 7) < 5) ? "Hafta içi" : "Hafta sonu";
Console.WriteLine("Gün : " + gün + " -> " + haftaSonu);

//Artırma ve Azaltma Operatörleri
// ++ : Artırma, -- : Azaltma
//Unary operators

int sayi = 5;
Console.WriteLine("Başlangıç sayi : " + sayi);
sayi = sayi + 1;
Console.WriteLine("Sayi : " + sayi);
sayi++; // sayi = sayi + 1 ile aynı
Console.WriteLine("Sayi : " + sayi);

sayi = sayi - 1;
Console.WriteLine("Sayi : " + sayi);
sayi--; // sayi = sayi - 1 ile aynı
Console.WriteLine("Sayi : " + sayi);

++sayi; // Önce artırır sonra kullanır
Console.WriteLine("Sayi : " + sayi);
--sayi; // Önce kullanır sonra azaltır
Console.WriteLine("Sayi : " + sayi);

int sayiA = sayi++;
Console.WriteLine("Sayi : " + sayi);
Console.WriteLine("SayiA : " + sayiA); // sayiA = 6
int sayiB = ++sayi;
Console.WriteLine("Sayi : " + sayi);
Console.WriteLine("SayiB : " + sayiB); // sayiA = 6

