Console.Write("Öğrenci sayısı : ");
int studentsCount = Convert.ToInt32(Console.ReadLine());
int[] studentList = new int[studentsCount];

for (int i = 0; i < studentsCount; i++)
{
    int not;
    do
    {
        Console.Write($"{i + 1}. Öğrencinin notunu giriniz : ");
        not = Convert.ToInt32(Console.ReadLine());
        if (not < 0 || not > 100)
        {
            Console.WriteLine("Hatalı not girdiniz...");
        }
    } while (not < 0 || not > 100);
    
    
    studentList[i] = not;
}

double average = 0;
int totalNote = 0;
foreach (var note in studentList)
{
    totalNote += note;
}
average = (double)totalNote / studentList.Length;
int unsuccessful = 0, successful = 0;
int max = 0, min = 100;
for (int i = 0; i < studentList.Length; i++)
{
    if (studentList[i] >= 50)
    {
        successful++;
    }
    else
    {
        unsuccessful++;
    }
}

for (int i = 0; i < studentList.Length; i++)
{
    if (max < studentList[i])
    {
        max = studentList[i];
    }

    if (min > studentList[i])
    {
        min = studentList[i];
    }
}

Console.WriteLine($"Sınıf Not Ortalaması\t: {average}\nBaşarılı Öğrenci Sayısı\t: {successful}\nBaşarısız Öğrenci Sayısı\t: {unsuccessful}\nEn Yüksek Not\t: {max}\nEn Düşük Not\t: {min}");