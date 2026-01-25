
int number1,number2;
double result;
string islem;
string islemText = null;

Console.Write("1. Sayı değeri : ");
number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("2. Sayı değeri : ");
number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Yapılacak işlemi seçiniz :\nToplama için (+)\nÇıkarma için (-)\nÇarpma için (x)\nBölme için (/)\nSeçilen işlem : ");
islem = Console.ReadLine();

if (islem == "+")
{
    result = number1 + number2;
    islemText = "Toplam :";
   // Console.WriteLine("Toplam : " + result);
} else if (islem == "-")
{
    result = number1 - number2;
    islemText = "Fark : ";
   // Console.WriteLine("Fark : " + result);
} else if (islem == "x")
{
    result =number1 * number2;
    islemText = "Çarpım : ";
    //Console.WriteLine("Çarpım : " + result);
} else if (islem == "/")
{
    result = Convert.ToDouble(number1) / Convert.ToDouble(number2);
    islemText = "Bölüm : ";
    //Console.WriteLine("Bölüm : " + result);
}
else
{
    result = 0;
    Console.WriteLine("Hatalı işlem");
}

Console.WriteLine(islemText + result);    
