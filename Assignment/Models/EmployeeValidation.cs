using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Assignment.Models
{
    public class EmployeeValidation
    {
        [Required(ErrorMessage = "enter Name")]
        public string Name { get; set; }
        [Range(18, 80, ErrorMessage = "Age is not less than 18")]
        public string Age { get; set; }
        [Required(ErrorMessage = "enter Salary")]
        public string salary { get; set; }


        public EmployeeValidation EmployeeValidations { get; set; }
    }
}