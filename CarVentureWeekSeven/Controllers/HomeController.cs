using CarVentureCore.Interface;
using CarVentureCore.Model;
using CarVentureWeekSeven.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CarVentureWeekSeven.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarsLocation _carsLocation;
        private string _Location;
        public HomeController(ILogger<HomeController> logger, ICarsLocation carsLocation)
        {
            _logger = logger;
            _carsLocation = carsLocation;
        }

        public async Task<IActionResult> Index()
        {
            await LocationMethodAsync();
            IndexModel indexView = new IndexModel();
            indexView.Cars = await _carsLocation.GetAllCars();
            indexView.ReadList = await _carsLocation.GetAllStories();
            return View(indexView);
        }

        [HttpPost]
        public async Task<IActionResult> Index(IndexModel model)
        {
            _Location = model.Location;
            await LocationMethodAsync();
            if (model.ReturnDate > model.PickUpDate)
            {
                return View("Search");
            }
            ModelState.AddModelError("ReturnDate", "Return Date needs to be after the Pick Up Date");
            return View(model);
        }

        public async Task<IActionResult> Search()
        {
            var cars = await _carsLocation.GetAllCarsByLocation(_Location);
            SearchModel searchmodel = new SearchModel();
            searchmodel.GetList = cars;
            return View(searchmodel);
        }

       public IActionResult Cars()
        {
           @ViewBag.Title = "Cars";
           return View();
        }

        public IActionResult Offers()
        {
            ViewBag.Title = "Offers";
            return View();
        }
        public IActionResult Locations()
        {
            ViewBag.Title = "Location";
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.Title = "contact";
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        private async Task LocationMethodAsync()
        {
            List<SelectListItem> list = new List<SelectListItem>();
            var car = await _carsLocation.GetAllLocations();
            foreach (var item in car)
            {
                list.Add(new SelectListItem { Text = item.LocationName, Value = item.LocationName });
            }
            ViewBag.LocationDrop = new SelectList(list, "Text", "Value");
        }

        private async Task CarsMethodAsync()
        {
            var cars = await _carsLocation.GetAllCars();
            ViewBag.Cars = cars;
        }
    }
}
