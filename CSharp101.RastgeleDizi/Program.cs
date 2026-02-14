//100 elemanlı bir dizimiz olsun ve biz bu dizinin elemanların 1 ile 10 arasında rastgele değer atayalım.

// Hangi sayıdan kaç adet üretildiğini ekrana yazdıran program 

using System.Threading.Channels;

Random rnd = new Random();
int[] numbers = new int[100];

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(1,11);
}

int[] adet = new int[10];
//foreach (var VARIABLE in adet)
//{
//    Console.WriteLine(VARIABLE);
//}

for (int i = 0; i < numbers.Length; i++)
{
    adet[numbers[i] - 1] += 1;
}

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{i} sayısının adedi : {adet[i-1]}");
    Console.WriteLine(new string('*',25));
}
//foreach (var VARIABLE in numbers)
//{
//    Console.WriteLine(VARIABLE);
//}