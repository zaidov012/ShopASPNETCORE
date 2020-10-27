using ShopASPNETCORE.Data.Interfaces;
using ShopASPNETCORE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopASPNETCORE.Data.Mocks
{
    public class MockCar : ICar
    {
        private readonly ICarsCategory carsCategory = new MockCategory();
        public IEnumerable<Car> AllCars 
        {
            get 
            {
                return new List<Car>
                {
                    new Car { Name="BMW", ShortDescription = "",        LongDescription = "", Img = "", Price = 45000, IsFavorite=true,  Available=true,     Category = carsCategory.AllCategories[1] },
                    new Car { Name="Prius", ShortDescription = "",      LongDescription = "", Img = "", Price = 15000, IsFavorite=false, Available=true,    Category = carsCategory.AllCategories[0] },
                    new Car { Name="Mercedes", ShortDescription = "",   LongDescription = "", Img = "", Price = 35000, IsFavorite=true,  Available=true,     Category = carsCategory.AllCategories[1] },
                    new Car { Name="Tesla", ShortDescription = "",      LongDescription = "", Img = "", Price = 55000, IsFavorite=true,  Available=true,     Category = carsCategory.AllCategories[0] },
                    new Car { Name="Mitsubishi", ShortDescription = "", LongDescription = "", Img = "", Price = 25000, IsFavorite=false, Available=true,    Category = carsCategory.AllCategories[1] },
                    new Car { Name="Honda", ShortDescription = "",      LongDescription = "", Img = "", Price = 17000, IsFavorite=false, Available=true,    Category = carsCategory.AllCategories[0] }
                };
            }
            set
            {

            }
        }
        public IEnumerable<Car> FavCars { get; set; }

        public Car GetCar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
