using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignFix.Models
{
    public class SignOrderFormViewModel
    {
        public class CreateSignOrderformViewModel
        {
            [Required]
            [Display(Name = "Size")]           // check box
            public string Size { get; set; }

            [Required]
            [Display(Name = "Sides")]
            public string Sides { get; set; } //check box 

            //[Display(Name = "Middle Name")]
            //public string MiddleName { get; set; }
            [Required]
            [Display(Name = "Number of Signs")]
            public int number_signs { get; set; }

            [Required]
            [Display(Name = "Number of Stakes ")]
            //[DataType(DataType.PhoneNumber)]
            public int number_stakes { get; set; }

            // Additional Notes
            [Display(Name = "Additional Notes")]
            public string Category { get; set; } // Big test box area

      
            // file upload for art work 
            
        }
    }
}