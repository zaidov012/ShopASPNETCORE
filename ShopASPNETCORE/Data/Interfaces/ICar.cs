using ShopASPNETCORE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopASPNETCORE.Data.Interfaces
{
    public interface ICar
    {
        IEnumerable<Car> AllCars { get; set; }
        IEnumerable<Car> FavCars { get; set; }
        Car GetCar(int id);

    }
}
