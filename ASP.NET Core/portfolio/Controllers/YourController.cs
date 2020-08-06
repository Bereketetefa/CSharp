using Microsoft.AspNetCore.Mvc;
namespace portfolio
{

    public class YourController : Controller
    {

        [HttpGet("")]
        public string Index()
        {
            return "This is my Index!";
        }
        [HttpGet("projects")]
        // [Route("projects")]
        public string About()
        {
            return "These are my Projects";
        }
        [HttpGet("contact")]
        public string FormSubmission()
        {
            return "This is my Contact!";
        }
    }
}
        // [Route("submission")]
        // POST requests to "localhost:5000/submission" go here
        // (Don't worry about form submissions for now, we will get to those later!)