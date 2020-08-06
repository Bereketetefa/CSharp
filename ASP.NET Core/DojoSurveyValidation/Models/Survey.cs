using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DojoSurveyValidation.Models
{
    public class Survey
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required(ErrorMessage="Needs a Location")]
        public string Location { get; set; }

        [Required(ErrorMessage="Needs a Language")]
        public string Language { get; set; }

        [Required(ErrorMessage = "More than 20 Characters required")]
        [MinLength(20)]
        public string Description { get; set; } 
    }
}

