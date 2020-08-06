using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace BeltExam.Models
{
    public class Activities
    {
        [Key]
        public int ActivitiyId { get; set; }

        [Required(ErrorMessage = "Event Title is required")]
        [MinLength(2, ErrorMessage = "Full Name must be at least 2 characters.")]
        public string Title { get; set; }

        
        [Required(ErrorMessage = "Duaration Name is required")]        
        public int Duration { get; set; } 


        [Required(ErrorMessage = "Please select Upcoming Date, for Activity Date ")]
        public DateTime ActivityDate { get; set; } 


        [Required]
        [MinLength(2, ErrorMessage = "Description must be at least 2 characters.")]
        public string Description { get; set; }


        [Required]
        public string Hour { get; set; }


        public List<Join> JoinList { get; set; }


        public int ActivityPlanner { get; set; }

    }
}