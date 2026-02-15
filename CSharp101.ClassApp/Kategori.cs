namespace CSharp101.ClassApp;
//Entity Classes - Varlık Sınıfı
public class Kategori
{
    public int Id { get; set; }
    public string Adi { get; set; }

    public void GetKategori()
    {
        Console.WriteLine(Adi);
    }
}