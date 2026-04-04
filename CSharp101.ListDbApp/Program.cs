using CSharp101.ListDbApp;

//List<City> cities = new List<City>();
//City[] cityList = new City[0];

//City city = new City();
//city.Name = "İstanbul";
//city.Id = 34;

//cities.Add(city);
//City[] ct2 = new City[1];
//ct2[0] = city;
////cityList dizim 0 elemanlı
////cityList = ct2;
//ct2 = cityList;


//Console.WriteLine(cityList[0].Name);
//Console.WriteLine(cities[0].Name);

//ct2[0].Name = "Ankara";
//cityList[0].Id = 6;

//Console.WriteLine(cityList[0].Name);
//Console.WriteLine(ct2[0].Id);

//CityList cities = new CityList();

////cities.Cities.Add(new City() { Id = 34, Name = "İstanbul" });
//foreach (var city in cities.Cities)
//{
//    Console.WriteLine($"Plaka\t:{city.Id} - Şehir\t:{city.Name}");
//}



//Console.WriteLine("Listeye Şehir Ekleyin :\nPlaka Kodu\t:");
//int plaka = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Şehir Adı\t:");
//string cityName = Console.ReadLine();

//City newCity = new City();
//newCity.Id = plaka;
//newCity.Name = cityName;

//cities.Cities.Add(newCity);

//foreach (var city in cities.Cities)
//{
//    Console.WriteLine($"Plaka\t:{city.Id} - Şehir\t:{city.Name}");
//}



foreach (var item in DataSourceDb.Categories)
{
    Console.WriteLine($"Kategori Adı : {item.Name}");
}

Console.WriteLine(Math.PI);
Console.WriteLine(Math.Sqrt(25));

Console.ReadLine();