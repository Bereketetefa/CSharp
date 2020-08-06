using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheifsnDishes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace CheifsnDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context { get; set; }
        public HomeController(MyContext context)
        {
        _context = context;
        }
// Display Chefs
        [HttpGet("")]
        public IActionResult Index()
        {
            List<Chef> AllChefs = _context.chefs
            .Include(chef => chef.dishs)
            .ToList();
            ViewBag.allchefs = AllChefs;
            return View();
        }
    
// Display Dishes
        [Route("Dishes")]
        [HttpGet]
        public IActionResult Dishes()
        {
            List<Dish> AllDishes = _context.dishs
            .Include(dish =>dish.Creator)
            .ToList();
            ViewBag.alldishes = AllDishes;
            return View("Dishes");
        }
// Add Chef
        [HttpGet]
        [Route(("AddChef"))]
        public IActionResult AddChef()
        {
            return View("AddChef");
        }

        [HttpPost]
        [Route("AddChef")]
        public IActionResult AddChef(Chef chef)
        {
            if(ModelState.IsValid)
            {
                if(chef.Birthday >= DateTime.Today)
                {
                    ModelState.AddModelError("Birthday", "Birthday must be from the past!");
                    return View("AddChef");
                }
                Chef newChef = new Chef
                {
                    FirstName = chef.FirstName,
                    LastName = chef.LastName,
                    Birthday = chef.Birthday,
                };
                _context.Add(newChef);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("AddChef");
            }
        }
// Add Dish
        [HttpGet]
        [Route("AddDish")]
        public IActionResult AddDishView()
        {
            List<Chef> AllChefs = _context.chefs.ToList();
            ViewBag.allchefs = AllChefs;
            return View("AddDish");
        }
        [HttpPost]
        [Route("AddDish")]
        public IActionResult AddDish(Dish dish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(dish);
                _context.SaveChanges();
                return RedirectToAction("AddDishView");
            }
            else
            {
                List<Chef> AllChefs = _context.chefs.ToList();
                ViewBag.allchefs = AllChefs;
                return View("AddDish", dish);
            }
        }  
    }
}
