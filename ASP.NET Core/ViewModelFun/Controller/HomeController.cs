using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers     
{
    public class HomeController : Controller   
    {
            [HttpGet("")]
            public IActionResult Index()
            {
                string[] message = new string[]
                {
                "The amber droplet hung from the branch, reaching fullness and ready to drop. It waited. While many of the other droplets were satisfied to form as big as they could and release, this droplet had other plans. It wanted to be part of history. It wanted to be remembered long after all the other droplets had dissolved into history. So it waited for the perfect specimen to fly by to trap and capture that it hoped would eventually be discovered hundreds of years in the future."
                };
                return View(message);
            }

            [HttpGet("Numbers")]
            public IActionResult Numbers()
            {
                int[] numbers = new int[]
                {
                10,
                11,
                14,
                31,
                44,
                22
                };
                return View(numbers);
            }

            [HttpGet("users")]
            public IActionResult Users()
        {
            // to a View that has defined a model as @model string[]
            List<string> users = new List<string>()
            {
            "Sally", 
            "Billy", 
            "Joey", 
            "Moose"
            };
            return View(users);
        }
            [HttpGet("user")]
            public IActionResult User()
        {
            // to a View that has defined a model as @model string[]
            List<string> user = new List<string>()
            {
            "Sally" 
            };
            return View(user);
        }
    }
}
