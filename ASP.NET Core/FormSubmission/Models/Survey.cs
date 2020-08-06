using System;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Survey.Models
{
    public class User
    {
        [Required(ErrorMessage = "Need more than 4 Characters")]
        [MinLength(4)]
        public string Firstname { get; set; }

        [Required]
        [MinLength(4)]
        public string Lastname { get; set; }

        [Required]
        [MinLength(0)]
        public string Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
