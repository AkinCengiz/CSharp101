Console.Write("Öğrenci sayısı : ");
int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

int[,] matris = new int[ogrenciSayisi,3];

for(int i = 0; i <= matris.GetUpperBound(0);i++)
{
    for (int j = 0; j <= matris.GetUpperBound(1); j++)
    {
        int not;
        Console.Write($"{i+1}. Öğrencinin {j+1}. notu : ");
        not = Convert.ToInt32(Console.ReadLine());
        matris[i,j] = not;
    }
}


for (int i = 0; i <= matris.GetUpperBound(0); i++)
{
    Console.Write($"{i+1}. öğrencinin -> ");
    for (int j = 0; j <= matris.GetUpperBound(1); j++)
    {
        Console.Write($"{j+1}. Notu {matris[i,j]} - ");
    }

    Console.WriteLine();
}

double[] ortalamalar = new double[ogrenciSayisi];

for (int i = 0; i < ortalamalar.Length; i++)
{
    double gecici = ((double)matris[i, 0] + matris[i, 1]) / 2;
    if (gecici < 50)
    {
        gecici = ((double)matris[i, 0] + matris[i, 2]) / 2;
    }
    ortalamalar[i] = gecici;
}

foreach (var ortalama in ortalamalar)
{
    Console.WriteLine($"Ortalama : {ortalama}");
}

/* ============================================ÖDEV============================================
 * Dizi sıralama ile ilgili örnek yapılacak
 * Bu projedeki notlar kısmında kontroller yapılacak eğer not 0 dan küçük ya da 100 den büyükse kullanıcıdan tekrar not girmesi istenecek.
 *
 * Bu projede ortalamaya göre öğrencinin geçip geçmediği bilgisi yazılacak.
 */