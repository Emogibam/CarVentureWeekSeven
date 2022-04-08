using CarVentureCore.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarVentureWeekSeven.Controllers
{
    public class SearchController : Controller
    {
        private readonly ICarsLocation _carsLocation;
        public SearchController(ICarsLocation carsLocation)
        {
            _carsLocation = carsLocation;
        }
        public async Task<IActionResult> Search()
        {
            var cars = await _carsLocation.GetAllCars();
            ViewBag.Cars = cars;
            return View();
        }
    }
}
