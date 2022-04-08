using CarVentureCore.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarVentureWeekSeven.Models
{
    public class SignUpModel
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Please enter the Full Name")]
        [RegularExpression(@"^[A-Z]")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "Please enter the Age")]
        [RegularExpression(@"^[0-9]")]
        public uint Age { get; set; }
        [Required(ErrorMessage = "Please enter the Emall")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter the Password")]
        [RegularExpression(@"^[A-Z]")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please enter the Phone")]
        [RegularExpression(@"^[0-9]")]
        public string Phone { get; set; }
        public List<User> Users { get; set; }
    }
}
