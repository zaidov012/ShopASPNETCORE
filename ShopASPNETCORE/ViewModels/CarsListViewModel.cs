using ShopASPNETCORE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopASPNETCORE.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> GetCars { get; set; }
        public string CarCategory { get; set; }

    }
}
