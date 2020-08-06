using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Survey.Models;


namespace HelloWorld.Controllers     
{
    public class HomeController : Controller   
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost("submit")]
        public IActionResult submit(User input)
        {
            
            if(ModelState.IsValid){
                return View("Register");
            }
            else
            {
            return View("Index");
            }
        }

        [HttpGet("Register")]
        public IActionResult Register(User input)
        {
            {
                return View("Register");
            }
        }
    }
}