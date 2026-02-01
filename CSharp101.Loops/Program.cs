//Loops - Döngüler
// C# dilinde döngüler, belirli bir kod bloğunu tekrar tekrar çalıştırmak için kullanılır. En yaygın kullanılan döngü yapıları for, while ve do-while döngüleridir. Aşağıda her bir döngü türü için örnekler bulunmaktadır:


// For Döngüsü


Console.WriteLine("1");
Console.WriteLine("2");
Console.WriteLine("3");
Console.WriteLine("4");
Console.WriteLine("5");
Console.WriteLine("6");
Console.WriteLine("7");
Console.WriteLine("8");
Console.WriteLine("9");
Console.WriteLine("10");
Console.WriteLine("11");



for (int i = 1; i <= 5; i+=2)
{
	Console.WriteLine($"For Döngüsü - Sayı: {i}");
}



// While Döngüsü
int j = 1;
while (j <= 5)
{
	Console.WriteLine($"While Döngüsü - Sayı: {j}");
	j++;
}
j = 1;


for (; j <= 5;)
{
	Console.WriteLine($"For döngüsü While Görüntülü - Sayı: {j}");
	j++;
}

Console.WriteLine("J : " + j);

// Do-While Döngüsü
do
{
	Console.WriteLine($"Do While Döngüsü - Sayı: {j}");
	j++;
}while (j <= 5);

j = 1;

do
{
	Console.WriteLine($"Do While Döngüsü - Sayı: {j}");
	j++;
} while (j <= 5);

j = 1;



do
{
	j++;
	Console.WriteLine($"Do While Döngüsü - Sayı: {j}");
} while (j <= 5);