using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers     
{
    public class HomeController : Controller   
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
    }
}