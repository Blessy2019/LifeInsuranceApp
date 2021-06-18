using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeInsuranceApp.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Required field")]
        [RegularExpression("[a-zA-Z]*$", ErrorMessage = "Invalid Last Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Required field")]
        [RegularExpression("[a-zA-Z]*$", ErrorMessage = "Invalid Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required field")]
        public string Gender { get; set; }

        public string Age { get; set; }

        [Display(Name = "Date of Birth (mm/dd/yyyy) ")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfBirth { get; set; }

        public string Occupation { get; set; }
        public IEnumerable<SelectListItem> OccupationList { get; set; }

        [Required(ErrorMessage = "Required field")]
        [Display(Name = "Insured Amount")]

        [RegularExpression("^[0-9]*$", ErrorMessage = "Invalid number")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:#,#.##}")]
        public Nullable<decimal> DeathSumInsured { get; set; }

        public string Rating { get; set; }

        public double RatingFactor { get; set; }

        public string Message { get; set; }

        //[DisplayFormat(DataFormatString = "{0:n2}", ApplyFormatInEditMode = true)]
        public decimal Total { get; set; }
    }
}