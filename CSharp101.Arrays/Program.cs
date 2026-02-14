using System.Collections;
using System.Runtime.InteropServices.JavaScript;

int[] sayilar;
sayilar = new int[5];
int[] sayilar2   = new int[10];

int[] sayilar3 = [1,2,3,4,5,6,7,8,9,10];

for (int i = 0; i < sayilar2.Length; i++)
{
	if (i < 5)
	{
		Console.WriteLine($"Sayilar2[{i}] = {sayilar2[i]} <===> Sayilar3[{i}] = {sayilar3[i]} <===> Sayilar[{i}] = {sayilar[i]}");
	}
	else
	{
		Console.WriteLine($"Sayilar2[{i}] = {sayilar2[i]} <===> Sayilar3[{i}] = {sayilar3[i]}");
	}
		
}

sayilar = [4, 7, 9, 11, 4, 3,6]; // C# 12.0 ile gelen yeni dizi tanımlama ve atama yöntemi bu şekilde de yapılabilir. Ancak bu şekilde tanımlama yaparken dizinin boyutunu belirtmeye gerek yoktur. Dizinin boyutu, atanan eleman sayısına göre otomatik olarak belirlenir. Bu satırdan sonra yukarıda sayilar dizisi için yapılan tanımlama ve boyut belirtme işlemi gereksiz hale gelir. Yani, sayilar artık 7 elemanlıdır.

sayilar = new int[7];
sayilar[0] = 4;
sayilar[1] = 7;
sayilar[2] = 9;
sayilar[3] = 11;
sayilar[4] = 4;
sayilar[5] = 3;
sayilar[6] = 6;

foreach (var sayi in sayilar)
{
	Console.WriteLine(sayi);
}

string[] cities = ["Ankara", "İstanbul", "İzmir", "Bursa", "Adana"];
string[] aylar = new string[12];
aylar[0] = "Ocak";
aylar[1] = "Şubat";
aylar[2] = "Mart";
aylar[3] = "Nisan";
aylar[4] = "Mayıs";
aylar[5] = "Haziran";
aylar[6] = "Temmuz";
aylar[7] = "Ağustos";
aylar[8] = "Eylül";
aylar[9] = "Ekim";
aylar[10] = "Kasım";
aylar[11] = "Aralık";

foreach (var ay in aylar)
{
	Console.WriteLine(ay);
}

for (int i = 0; i < aylar.Length; i++)
{
	Console.WriteLine(aylar[i]);
}

int index = 0;
while(index < aylar.Length)
{
	Console.WriteLine(aylar[index]);
	index++;
}

int max = 0;
for (int i = 0; i < sayilar.Length; i++)
{
	if (sayilar[i] > max)
	{
		max = sayilar[i];
	}
}

Console.WriteLine("Maksimum eleman : " + max);

List<int> sayilarListesi = new List<int>();
sayilarListesi.Add(4);
sayilarListesi.Add(7);
sayilarListesi.Add(9);
List<object> deneme = new();

ArrayList listAylar = new ArrayList();
listAylar.Add("Ocak");
listAylar.Add(5);
int[,] matris = new int[3, 3]
{
	{1,2,3},
	{4,5,6},
	{7,8,9}
};

int[,,] ucboyut = new int[2, 2, 2]
{
	{
		{1,2},
		{3,4}
	},
	{
		{5,6},
		{7,8}
	}
};

//GetUpperBound() metodu bir dizinin belirli bir boyutundaki en yüksek geçerli indeks değerini döndürür. Örneğin, GetUpperBound(0) birinci boyutun en yüksek indeksini, GetUpperBound(1) ikinci boyutun en yüksek indeks
//ini verir. Bu, çok boyutlu dizilerde döngüleri doğru şekilde yapılandırmak için kullanışlıdır, çünkü dizinin boyutunu bilmeden en yüksek indeks değerine erişmenizi sağlar.


//                         x=>  0  1 // GetUpperBound(x)
string[,] sehirler = new string[3, 3] // 
{
	{"Ankara", "İstanbul", "İzmir"},//0
	{"Bursa", "Adana", "Antalya"},//1
	{"Trabzon", "Samsun", "Ordu"}//2
};
string[,] cities2 = new string[3, 4];

cities2[0,0] = "İstanbul";
cities2[0,1] = "Kocaeli";
cities2[0,2] = "Sakarya";
cities2[0,3] = "Edirne";
cities2[1,0] = "Ankara";
cities2[1,1] = "Konya";
cities2[1,2] = "Kayseri";
cities2[1,3] = "Eskişehir";
cities2[2,0] = "İzmir";
cities2[2,1] = "Aydın";
cities2[2,2] = "Muğla";
cities2[2,3] = "Denizli";

for (int i = 0; i <= cities2.GetUpperBound(0); i++)
{
	for (int j = 0; j <= cities2.GetUpperBound(1); j++)
	{
		Console.WriteLine($"Cities[{i},{j}] = {cities2[i,j]}");
	}
}

for (int i = 0; i < 3; i++)
{
	for (int j = 0; j < 4; j++)
	{

	}
}

//for (int i = 0; i < sehirler.GetLength(0); i++)
//{
//	for (int j = 0; j < sehirler[i].GetLength(1); j++)
//	{

//	}
//}

Console.WriteLine("LENGTH ***************************");
for (int i = 0; i < aylar.Length; i++)
{
	Console.WriteLine(aylar[i]);
}

Console.WriteLine("UPPER BOUND**************************");
for (int i = 0; i <= aylar.GetUpperBound(0); i++)
{
	Console.WriteLine(aylar[i]);
}



//GetUpperBound(3) => 1
//GetUpperBound(4) => 2


//[0,0] = 0 [0,1] = 1 [0,2] = 2 [0,3] = 3 [0,4] = 4
//[1,0] = 4 [1,1] = 5 [1,2] = 6 [1,3] = 7 [1,4] = 8
//[2,0] = 8 [2,1] = 9 [2,2] = 10 [2,3] = 11 [2,4] = 12
//[3,0] = 12 [3,1] = 13 [3,2] = 14 [3,3] = 15 [3,4] = 16
int[,] ikiBoyutlu = new int[4,5];

for (int i = 0; i <= ikiBoyutlu.GetUpperBound(0); i++)
{
	for (int j = 0; j <= ikiBoyutlu.GetUpperBound(1); j++)
	{
		ikiBoyutlu[i, j] = (i + j) * 3;
	}
}

for (int i = 0; i <= ikiBoyutlu.GetUpperBound(0); i++)
{
	for (int j = 0; j <= ikiBoyutlu.GetUpperBound(1); j++)
	{
		Console.Write("[{1},{2}] -> {0,2} | ",ikiBoyutlu[i,j],i,j);
	}

	Console.WriteLine();
}

/*
 *
 *
 *    [
 *				   0  1  2  3  4
 *			0 => { 0, 3, 6, 9,12},
 *			1 => { 3, 6, 9,12,15},
 *			2 => { 6, 9,12,15,18},
 *			3 => { 9,12,15,18,21}*
 *     ]
 *
 *		[
   *				   
   *			{ 0, 3, 6, 9,12},
   *			{ 3, 6, 9,12,15},
   *			{ 6, 9,12,15,18},
   *			{ 9,12,15,18,21}*
   *     ]
 *
 *
 *
 *
 *
 */