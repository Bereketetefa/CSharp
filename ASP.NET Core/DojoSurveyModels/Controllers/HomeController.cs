using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// using Survey.Models;

namespace HelloWorld.Controllers     
{
    public class HomeController : Controller   
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }


        [HttpPost("survey")]
        public IActionResult Results(Survey yourSurvey)
        {
            // @ViewBag.Name = Name;
            // @ViewBag.Location = Location;
            // @ViewBag.Language = Languages;
            // @ViewBag.Description = Description;
            return View(yourSurvey);
        }
    }
}