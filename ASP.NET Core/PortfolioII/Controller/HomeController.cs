using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers     
{
    public class HomeController : Controller   
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            // string message = "don't let Benny Bob into your mainframe.";
            // ViewBag.Message = message;
            return View();
        }

        [HttpGet("/Projects")]
        public ViewResult Projects()
        {
            return View("Projects");
        }

        [HttpGet("/Contacts")]
        public ViewResult Contacts()
        {
            return View("Contacts");
        }
    }
}