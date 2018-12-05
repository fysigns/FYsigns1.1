using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SignFix.Models
{
    public class NewSignPlacmentFormViewModel
    {
        [Required]
        [Display(Name = "Number of Signs")]
        public int number_signs_new { get; set; }

        [Required]
        [Display(Name = "Zipcode ")]
        public int Zipcode { get; set; }

        //calendar
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Placementdate {get;set;}


    // Additional Notes
    [Display(Name = "Additional Notes")]
        public string Notes { get; set; } // Big test box area


        // file upload for art work 


    }
}