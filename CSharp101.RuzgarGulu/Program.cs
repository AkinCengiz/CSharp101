
Console.Write("Genişlik giriniz : ");
int boyut = Convert.ToInt32(Console.ReadLine());
if (boyut % 2 == 0)
{
	boyut--;
}
int[,] dizi = new int[boyut,boyut];

for(int i = 0; i < dizi.GetLength(0); i++)
{
	for(int j = 0; j < dizi.GetLength(1); j++)
	{
		if (i == j)
		{
			dizi[i,j] = 1;
		}

		if (i == (boyut -1) /2 || j == (boyut - 1) / 2)
		{
			dizi[i,j] = 1;
		}

		if (i + j == boyut -1)
		{
			dizi[i,j] = 1;
		}
	}
}

for (int i = 0; i <= dizi.GetUpperBound(0); i++)
{
	for (int j = 0; j <= dizi.GetUpperBound(1); j++)
	{
		if (dizi[i, j] == 1)
		{
			Console.Write(" * ");
		}
		else
		{
			Console.Write("   ");
		}
	}
	Console.WriteLine();
}