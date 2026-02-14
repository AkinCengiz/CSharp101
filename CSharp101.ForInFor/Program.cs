
int satir, sutun;

Console.Write("Satır sayısını giriniz : ");
satir = Convert.ToInt32(Console.ReadLine());
Console.Write("Sütun sayısını giriniz : ");
sutun = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < satir; i++)
{
	Console.WriteLine();
	for (int j = 0; j < sutun; j++)
	{
		Console.Write("*");
	}
	
}

