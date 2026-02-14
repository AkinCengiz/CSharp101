//break ve continue ifadeleri, döngülerde belirli koşullara göre döngünün akışını kontrol etmek için kullanılır.

//1. break ifadesi: Döngüyü tamamen sonlandırmak için kullanılır. break ifadesi, bulunduğu döngüden çıkış yapar ve döngünün geri kalanını atlar.
//2. continue ifadesi: Döngünün o anki iterasyonunu atlamak ve bir sonraki iterasyona geçmek için kullanılır. continue ifadesi, bulunduğu iterasyonu atlar ve döngünün bir sonraki iterasyonuna geçer.

for (int i = 0; 1 < 100; i++)
{
	
	if (i % 5 == 0)
	{
		continue;
	}
	
	if (i % 93 == 0)
	{
		break;
	}

	Console.WriteLine(i);
}