using System;
using System.ComponentModel.DataAnnotations;

namespace Login2.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage = "Enter your first name")]
        [MinLength(2, ErrorMessage = "First name must be at least 2 characters")]   
        public string first_name { get; set; }
        [Required(ErrorMessage = "Enter your last name")]
        [MinLength(2, ErrorMessage = "Last name must be at least 2 characters")]
        public string last_name { get; set; }
        [Required(ErrorMessage = "Enter your email")]
        [EmailAddress(ErrorMessage ="Enter a valid email address")]
        public string email { get; set; }
        [Required(ErrorMessage = "Enter a password")]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters")]
        public string password { get; set; }
        [Compare("password", ErrorMessage = "Passwords do not match")]
        public string password2 { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}