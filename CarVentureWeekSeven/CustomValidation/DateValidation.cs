using System.ComponentModel.DataAnnotations;
using System;
namespace CarVentureWeekSeven.CustomValidation
{
    public class DateValidation:ValidationAttribute
    {
        public DateValidation():base("{0} Date should be less than current date")
        {

        }

        public override bool IsValid(object value)
        {
            DateTime currentDate = Convert.ToDateTime(value);
            if(currentDate <= DateTime.Now)
                return true;
            else 
            return false;
        }
    }
}
