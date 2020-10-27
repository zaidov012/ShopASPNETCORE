using ShopASPNETCORE.Data.Interfaces;
using ShopASPNETCORE.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace ShopASPNETCORE.Data.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IList<Category> AllCategories
        {
            get 
            {
                return new List<Category>
                {
                    new Category { CategoryName = "ElectroCars" , Description = "Electro Cars Type"},
                    new Category {CategoryName = "ClassicCars", Description = "Usual Cars Type"}
                };
            }
        }

    }
}
