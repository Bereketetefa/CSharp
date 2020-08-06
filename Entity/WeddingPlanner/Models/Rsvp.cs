using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WeddingPlanner.Models
{
    public class RSVP
    {
        [Key]
        public int RSVPId { get; set; }
        public int WeddPlanId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Plan WeddPlan { get; set; }

    }
}