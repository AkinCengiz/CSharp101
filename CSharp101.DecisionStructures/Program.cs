//Karar Yapıları (Decision Structures)
// Karar yapıları, programların belirli koşullara bağlı olarak farklı yollar izlemesini sağlar.
// C# dilinde, karar yapıları genellikle if, else if, else ve switch ifadeleri kullanılarak uygulanır.

//If-Else Yapısı

int age = 17;

if (age >= 18)
{
	Console.WriteLine("Sitemize hoşgeldiniz...");
	/*
	 * farklı kodlar
	 * başka kodlar
	 * diğer kodlar
	 */
}
Console.WriteLine("Burası her koşulda çalışacak...");
Console.WriteLine("\n*************************************\n");
int not = 55;

if (not >= 65)
{
	Console.WriteLine("Tebrikler geçtiniz...");
}
else
{
	Console.WriteLine("Üzgünüz kaldınız...");
}

Console.WriteLine("Burası her koşulda çalışacak...");

int ortalama = 95;

if (ortalama < 0 || ortalama > 100)
{
	Console.WriteLine("Geçersiz bir not girdiniz...");
}
else if (ortalama >= 85)
{
	Console.WriteLine("Harf Notunuz: A");
}
else if (ortalama >= 75)
{
	Console.WriteLine("Harf Notunuz: B");
}
else if (ortalama >= 50)
{
	Console.WriteLine("Harf Notunuz: C");
}
else
{
	Console.WriteLine("Harf Notunuz: F");
}

Console.WriteLine("Burası her koşulda çalışacak...");


//Switch Yapısı
int gun = 3;
switch (gun)
{
	case 1:
		Console.WriteLine("Pazartesi");
		break;
	case 2:
		Console.WriteLine("Salı");
		break;
	case 3:
		Console.WriteLine("Çarşamba");
		break;
	case 4:
		Console.WriteLine("Perşembe");
		break;
	case 5:
		Console.WriteLine("Cuma");
		break;
	case 6:
		Console.WriteLine("Cumartesi");
		break;
	case 7:
		Console.WriteLine("Pazar");
		break;
	default:
		Console.WriteLine("Geçersiz gün numarası...");
		break;
}

gun = 3;
switch (gun)
{
	case 1:
	case 2:
	case 3:
	case 4:
	case 5:
		Console.WriteLine("Hafta içi");
		break;
	case 6:
	case 7:
		Console.WriteLine("Hafta sonu");
		break;
	default:
		Console.WriteLine("Geçersiz gün numarası...");
		break;
}