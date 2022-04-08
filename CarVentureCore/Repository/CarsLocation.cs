using CarVentureCore.Interface;
using CarVentureCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVentureCore.Repository
{
    public class CarsLocation:ICarsLocation
    {
        readonly private IReadFromJson _dbContext;
        private readonly string file = "Location.json";
        private readonly string carfile = "Cars.json";
        private readonly string readStory = "OurStories.json";
        public CarsLocation(IReadFromJson dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Location>> GetAllLocations()
        {
            return (List<Location>)await _dbContext.ReadJson<Location>(file);
        }
        public async Task<List<ReadStory>> GetAllStories()
        {
            return (List<ReadStory>)await _dbContext.ReadJson<ReadStory>(readStory);
        }
        public async Task<List<Cars>> GetAllCars()
        {
            return (List<Cars>)await _dbContext.ReadJson<Cars>(carfile);
        }
        public async Task<List<Cars>> GetAllCarsByLocation(string Location)
        {
            var getCar = (List<Cars>)await _dbContext.ReadJson<Cars>(carfile);
            List<Cars> result = new List<Cars>();
            if (getCar != null)
            {
                foreach (var car in getCar)
                {
                    if (car.Location == Location)
                    {
                        result.Add(car);
                    }
                }
            }
            return result;
        }
    }
}
