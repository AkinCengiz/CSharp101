using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp101.ListDbApp;
internal class CityList
{
    private List<City> _cities;

    public CityList()
    {
        _cities = new List<City>();
        _cities.Add(new City(){Id = 1, Name = "Adana"});
        _cities.Add(new City() { Id = 2, Name = "Adıyaman" });
        _cities.Add(new City() { Id = 69, Name = "Bayburt" });
        _cities.Add(new City() { Id = 58, Name = "Sivas" });
    }

    public List<City> Cities
    {
        get
        {
            return _cities;
        }
    }

}
