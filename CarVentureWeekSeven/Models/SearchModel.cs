using CarVentureCore.Model;
using System.Collections.Generic;

namespace CarVentureWeekSeven.Models
{
    public class SearchModel
    {
        public string Location { get; set; }
        public string PickUpDate { get; set; }
        public string ReturnDate { get; set; }
        public List<Cars> GetList { get; set; }
    }
}
