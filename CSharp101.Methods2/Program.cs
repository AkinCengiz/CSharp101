using System.Runtime.CompilerServices;

void HangisiBuyuk(int a, int b)
{
	if (a > b)
	{
		Console.WriteLine($"Büyük olan sayı : {a}");
	}else if (a < b)
	{
		Console.WriteLine($"Büyük olan sayı : {b}");
	}
	else
	{
		Console.WriteLine($"{a} = {b}");
	}
}

HangisiBuyuk(5,4);
HangisiBuyuk(9,15);
HangisiBuyuk(7,7);

int HangisiKucuk(int a, int b)
{
	if (a < b)
	{
		return a;
	}
	else if (a > b)
	{
		return b;
	}
	else
	{
		return 0;
	}
}

int kucukSayi = HangisiKucuk(5, 4);
Console.WriteLine("Küçük sayı {0}",kucukSayi);

int Carp(int a, int b, int c = 2)
{
	return a * b * c;
}

int Carpim(int a, int b=2, int c=4, int d=4)
{
	return a * b * c;
}

Console.WriteLine("Çarpım (5*4*3) : " + Carp(5, 4, 3));
Console.WriteLine("Çarpım (5*4) : " + Carp(5, 4));

Console.WriteLine("Çarpım (5*4) : " + Carpim(5, 4,6,8));

Console.WriteLine("Çarpım (5*4) : " + Carpim(5, 4));