//1 den 100 e kadar 5 e bölünen ancak 3 e bölünemeyen sayıları ekrana yazdıran, kaç adet olduğunu gösteren ve toplamlarını hesaplayan programı yazınız.
int adet = 0, toplam = 0;
for (int i = 1; i <= 100; i++)
{
	if (i % 5 == 0 && i % 3 != 0)
	{
		Console.WriteLine(" {0,3} ", i);
		adet++;
		toplam += i;
		
	}
}

Console.WriteLine($"Toplam\t: {toplam}\nAdet\t: {adet}");