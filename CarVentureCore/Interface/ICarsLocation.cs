using CarVentureCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarVentureCore.Interface
{
    public interface ICarsLocation
    {
        Task<List<Location>> GetAllLocations();
        Task<List<Cars>> GetAllCars();
        Task<List<Cars>> GetAllCarsByLocation(string Location);
        Task<List<ReadStory>> GetAllStories();
    }
}
