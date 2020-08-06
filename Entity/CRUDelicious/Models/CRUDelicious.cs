using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int FoodId { get; set; }
        [Required(ErrorMessage="Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage="FoodType is required")]
        public string FoodType { get; set; }
        [Required(ErrorMessage="Chef is required")]
        public string Chef { get; set; }
        [Required(ErrorMessage="Calories is required")]
        public string Calories { get; set; }
        [Required(ErrorMessage="Tastiness is required")]
        public string Tastiness { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}