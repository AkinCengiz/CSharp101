int adet = 0;

for (int i = 0; i <= 100; i++)
{
	if (i % 5 == 0)
	{
		Console.Write(" {0,3} ",i);
		adet++;
		if (adet % 5 == 0)
		{
			Console.WriteLine();
		}
	}
	
}

