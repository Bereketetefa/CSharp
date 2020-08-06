using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;


namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context {get;set;}
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("process")]
        public IActionResult process(Dish newbie)
        {
            if(ModelState.IsValid)
            {
                _context.Food.Add(newbie);
                _context.SaveChanges();
                return Redirect("/Dishlog");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("Dishlog")]
        public IActionResult Dishlog()
        {
            List<Dish> dishes = _context.Food.ToList();
            IEnumerable<Dish> meals = dishes.OrderByDescending(a => a.Title);
            return View(dishes);
        }

        [HttpGet]
        [Route("DishPage")]
        public IActionResult DishPage(int dish_id)
        {
            List<Dish> DishPage = _context.Food.ToList();
            IEnumerable<Dish> meals = DishPage.OrderByDescending(a => a.Title);
            // ViewBag.dishpage = DishPage;
            return View(DishPage);
        }

        [HttpGet]
        [Route("EditDish")]
        public IActionResult EditDish(int dish_id)
        {
            Dish retrievedDish = _context.Food.FirstOrDefault(dish => dish.FoodId == dish_id);
            ViewBag.Dishlog = retrievedDish;
            return View("EditDish");
        }

        [HttpGet("/delete/{dishID}")]
        public IActionResult Destroy(int FoodID)
        {
            Dish thisDish = _context.Food.FirstOrDefault(d=> d.FoodId == FoodID);
            _context.Food.Remove(thisDish);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        // [HttpGet("EditDish")]
        // public IActionResult delete_dish(Dish deleted_dish, int dish_id)
        // {
        //     Dish retrievedDish = _context.Food.FirstOrDefault(dish => dish.FoodId == dish_id);
        //     _context.Food.Remove(retrievedDish);
        //     _context.SaveChanges();
        //     return RedirectToAction("Index");
        // }
        // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        // public IActionResult Error()
        // {
        //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        // }
    }
}
