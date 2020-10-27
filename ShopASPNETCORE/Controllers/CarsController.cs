using Microsoft.AspNetCore.Mvc;
using ShopASPNETCORE.Data.Interfaces;
using ShopASPNETCORE.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopASPNETCORE.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICar _cars;

        public CarsController(ICar cars)
        {
            _cars = cars;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Cars Page";
            CarsListViewModel obj = new CarsListViewModel
            {
                GetCars = _cars.AllCars,
                CarCategory = "---Cars---"
            };
            return View(obj);
        }
    }
}
