using System;
using System.ComponentModel.DataAnnotations;

namespace CheifsnDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId { get; set; }

        [Required]
        [Display(Name = "Name of Dish:")]
        public string DishName { get; set; }

        [Required]
        [Display(Name = "# of Calories: ")]
        [Range(1, int.MaxValue, ErrorMessage="Please enter a value bigger than {1}")]
        public int Calories { get; set; }

        [Required]
        [Display(Name = "Description:")]
        public string Description {get; set;}  

        [Required]
        [Display(Name = "Tastiness ")]
        public string Tastiness { get; set; }

        [Required]
        [Display(Name = "Chef: ")]
        public int ChefId { get; set; }
        public Chef Creator { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}