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
    }
}