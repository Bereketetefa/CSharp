using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WeddingPlanner.Models
{
    public class Plan
    {
        [Key]
        public int PlanId { get; set; }

        [Required(ErrorMessage = "Groom Name is required")]
        [MinLength(2, ErrorMessage = "Full Name must be at least 2 characters.")]
        public string WedderOne { get; set; }


        [Required(ErrorMessage = "Bride Name is required")]
        [MinLength(2, ErrorMessage = "Full Name must be at least 2 characters.")]
        public string WedderTwo { get; set; }

        [Required(ErrorMessage = "Please select valid Upcoming Date, for Wedding Date !!!")]
        public DateTime WeddingDate { get; set; } 

        [Required]
        [MinLength(2, ErrorMessage = "Address must be at least 2 characters.")]
        public string Address { get; set; }
        public List<RSVP> GuestList { get; set; }
        public int Planner { get; set; }

    }
}