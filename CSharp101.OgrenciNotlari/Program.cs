Console.Write("Öğrenci sayısını giriniz\t: ");
int ogrenciSayisi = Convert.ToInt32(Console.ReadLine());

int[] notlar = new int[ogrenciSayisi];

for (int i = 0; i < notlar.Length; i++)
{
    int not;
    do
    {
        Console.Write($"{i + 1}. Öğrencinin Notu\t: ");
        not = Convert.ToInt32(Console.ReadLine());
        if (not < 0 || not > 100)
        {
            Console.WriteLine("Not değeri 0 - 100 arasında olmalıdır...");
        }
    } while (not < 0 || not > 100);

    notlar[i] = not;
}

int toplam = 0;
double ortalama = 0;
int basarili = 0, basarisiz = 0;

for (int i = 0; i < notlar.Length; i++)
{
    toplam += notlar[i];
    Console.WriteLine($"{i+1}. Öğrencinin notu : {notlar[i]}");
}


void Yazdir(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        toplam += arr[i];
        Console.WriteLine($"{i + 1}. Öğrencinin notu : {arr[i]}");
    }
}




ortalama = (double)toplam / notlar.Length;

int basla = 0;
while (basla < notlar.Length)
{
    if (notlar[basla] >= 50)
    {
        basarili++;
        //basla++;
    }
    else
    {
        basarisiz++;
        //basla++;
    }

    basla++;
}

int BasariliOgrenciSayisi()
{
    int basla = 0;
    int basarili = 0;
    while (basla < notlar.Length)
    {
        if (notlar[basla] >= 50)
        {
            basarili++;
            //basla++;
        }
        basla++;
    }
    return basarili;
}
int BasarisizOgrenciSayisi()
{
    int basla = 0;
    int basarisiz = 0;

    while (basla < notlar.Length)
    {
        if (notlar[basla] < 50)
        {
            basarisiz++;
            //basla++;
        }
        basla++;
    }
    return basarisiz;
}



int max = 0, min = 100;

for (int i = 0; i < notlar.Length; i++)
{
    if (notlar[i] > max)
    {
        max = notlar[i];
    }

    if (notlar[i] < min)
    {
        min = notlar[i];
    }
}

Console.WriteLine($"Öğrenci Sayısı\t: {ogrenciSayisi}\nSınıf Not Ortalaması\t: {ortalama}\nNotlar Toplamı\t:{toplam}\nBaşarılı Öğrenci Sayısı\t: {basarili}\nBaşarısız Öğrenci Sayısı\t: {basarisiz}\nEn Yüksek Not\t: {max}\nEn Düşük Not\t: {min}");


basarili = BasariliOgrenciSayisi();
basarisiz = BasarisizOgrenciSayisi();

Yazdir(notlar);

Console.WriteLine($"Öğrenci Sayısı\t: {ogrenciSayisi}\nSınıf Not Ortalaması\t: {ortalama}\nNotlar Toplamı\t:{toplam}\nBaşarılı Öğrenci Sayısı\t: {basarili}\nBaşarısız Öğrenci Sayısı\t: {basarisiz}\nEn Yüksek Not\t: {max}\nEn Düşük Not\t: {min}");