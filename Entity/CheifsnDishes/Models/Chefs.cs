using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CheifsnDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId { get; set; }
        [Required]
        [Display(Name = "First Name:")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name:")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime Birthday { get; set; }
        public int Age
        {
            get { return DateTime.Now.Year - Birthday.Year; }
        }   

        public DateTime CreatAt {get;set;} = DateTime.Now;
        public DateTime UpdatAt {get;set;} = DateTime.Now;

        public List<Dish> dishs { get; set;} = new List<Dish> ();
    }
}