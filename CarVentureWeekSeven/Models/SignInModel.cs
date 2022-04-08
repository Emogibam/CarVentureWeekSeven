using System.ComponentModel.DataAnnotations;

namespace CarVentureWeekSeven.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage = "Please enter the Emall")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter the Password")]
        [RegularExpression(@"^[A-Z]")]
        public string Password { get; set; }
    }
}
