// See https://aka.ms/new-console-template for more information

string firstName, lastName;
byte age;
//string yas;

Console.Write("İsminiz : ");
firstName = Console.ReadLine();
Console.Write("Soyisminiz : ");
lastName = Console.ReadLine();
Console.Write("Yaşınız : ");
age = Convert.ToByte(Console.ReadLine());
//yas= Console.ReadLine();


Console.WriteLine($"BİLGİLERİNİZ\t:\n*******************\nİsim\t: {firstName}\nSoyisim\t: {lastName}\nYaş\t: {age}");
