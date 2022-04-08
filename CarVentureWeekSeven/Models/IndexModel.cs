using CarVentureCore.Model;
using CarVentureWeekSeven.CustomValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarVentureWeekSeven.Models
{
    public class IndexModel
    {
        [Required]
        public string Location { get; set; }
        public DateTime PickUpDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public List<Cars> Cars { get; set; }
        public List<Location> Locations { get; set; }
        public List<ReadStory> ReadList { get; set; }
    }
}
