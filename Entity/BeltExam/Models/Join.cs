using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BeltExam.Models
{
public class Join
    {
        [Key]
        public int JoinId { get; set; }
        public int ActivitiyId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public Activities Active { get; set; }

    }
}