using RestApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace RestApi.Controllers
{
    public class CitiesController : ApiController
    {
        List<City> cities = new List<City>
        {
            new City{Id=0, Name = "Holstebro"},
            new City{Id=1, Name = "Herning"},
            new City{Id=2, Name = "Århus"},
            new City{Id=3, Name = "Vejle"},
            new City{Id=4, Name = "Skive"},
            new City{Id=5, Name = "Odense"},
        };

        public IEnumerable<City> Get()
        {
            return cities.ToList();
        }

        public City Get(int id)
        {
            try
            {
                return cities.FirstOrDefault(x => x.Id == id);
            }
            catch (Exception)
            {

                return new City();
            }
        }
    }
}
