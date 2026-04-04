using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CSharp101.ListDbApp;
internal static class DataSourceDb
{
    public static List<City> Cities = new List<City>()
    {
        new City(){Id = 1, Name = "Adana"},
        new City() { Id = 2, Name = "Adıyaman" },
        new City() { Id = 69, Name = "Bayburt" },
        new City() { Id = 58, Name = "Sivas" }
    };
    public static List<Category> Categories = new List<Category>()
    {
        new Category(){Id = 1, Name = "Teknoloji"},
        new Category(){Id = 2, Name = "Mobilya"},
        new Category(){Id = 3, Name = "Cep Telefonu"},
        new Category(){Id = 4, Name = "Televizyon"}
    };

}
