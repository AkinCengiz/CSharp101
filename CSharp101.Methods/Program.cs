//METOTLAR - METHODS
// C# dilinde metotlar, belirli bir işlevi yerine getiren kod bloklarıdır. Metotlar, kodunuzu daha düzenli ve yeniden kullanılabilir hale getirir. Aşağıda bir metot tanımlama ve çağırma örneği bulunmaktadır:
// Metot Tanımlama
// void ifadesi, metotun geriye değer döndürmediğini belirtir.
// Metot adı ve parametre listesi parantez içinde belirtilir.
// Metot Çağırma

string firstName = "John";
string lastName = "Doe";

Console.WriteLine("First Name : " + firstName);
Console.WriteLine("Last Name : " + lastName);

GetFullName();

firstName = "Muhammed";
lastName = "Saka";
GetFullName();
GetFullName();

string fullName = SetFullName();
Console.WriteLine("Metottan gelen : " + fullName);



void GetFullName()
{
	string fullName = $"{firstName} {lastName}";
	Console.WriteLine("Full Name : " + fullName);
	Console.WriteLine("Deneme 1");
	Console.WriteLine("Deneme 2");
	Console.WriteLine("Deneme 3");
}
string SetFullName()
{
	return $"{firstName} {lastName}";
}

// Metot çağrıldığında, metot adı ve gerekli parametreler parantez içinde belirtilir.
// Metotlar, kodunuzu daha düzenli ve okunabilir hale getirir.
// Ayrıca, aynı metodu birden fazla kez çağırarak kod tekrarını önler.

void EkranaYaz(string mesaj)
{
	Console.WriteLine(mesaj);
}

int sayi1 = 15;
int sayi2 = 25;

string note = $"Sayı 1 + Sayı 2 => {sayi1} + {sayi2} = {sayi1 + sayi2}";

EkranaYaz(note);

int Topla(int a, int b)
{
	return a + b;
}
string StrTopla(int a, int b)
{
	return (a + b).ToString();
}
int sonuc = Topla(sayi1, sayi2);

EkranaYaz(sonuc.ToString());

string strSonuc = StrTopla(sayi1, sayi2);
EkranaYaz(strSonuc);

int[] numbers = [1,2,3,4,5,6,7,8,9,10];

void CiftYazdirParametreli(int[] array)
{
	for (int i = 0; i < array.Length; i++)
	{
		if (array[i] % 2 == 0)
		{
			Console.WriteLine(array[i]);
		}
	}
}

void CiftYazdirParametresiz()
{
	for (int i = 0; i < numbers.Length; i++)
	{
		if (numbers[i] % 2 == 0)
		{
			Console.WriteLine(numbers[i]);
		}
	}
}

Console.WriteLine("Parametreli");
CiftYazdirParametreli(numbers);
Console.WriteLine("Parametresiz");
CiftYazdirParametresiz();

int[] number2 = [13,22,35,46,57,68,79,80,91,100];
CiftYazdirParametreli(number2);
CiftYazdirParametresiz();