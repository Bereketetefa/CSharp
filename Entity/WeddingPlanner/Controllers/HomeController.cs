using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers
{
    public class HomeController : Controller
    { private MyContext _context { get; set; }

        public HomeController(MyContext context)
        {
        _context = context;
        }

// This works on the Register page
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
// This is the Dashboard page
        [Route("Dashboard")]
        [HttpGet]
        public IActionResult Dashboard(int PlanId)
        {
            List<Plan> weddings = _context.weddPlans
            .Include(t => t.GuestList)
            .ThenInclude(k => k.User)
            .ToList();
            ViewBag.weddings = weddings;
            // ViewBag.User = (int)HttpContext.Session.GetInt32("UserId");
            return View();
        }
        [HttpPost]
        [Route("Dashboard")]
        public IActionResult Dashboard(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Users.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetString("LoggedIn", "LoggedIn");
                HttpContext.Session.SetInt32("UserId", newUser.UserId);

                var userInDb = _context.Users.FirstOrDefault(u => u.Email == newUser.Email);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }
// This is for logging in 
        [Route("Login")]
        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }

        [Route("Login")]
        [HttpPost]
        public IActionResult Login(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.LoginEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Login");
                }
                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.LoginPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LoginPassword", "Invalid Email/Password");
                    return View("Login");
                }
                HttpContext.Session.SetString("LoggedIn", "LoggedIn");
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            else
            {
                return View("Index");
            }
        }
//This submits registration request
        [Route("Weddingbuild")]
        [HttpGet]
        public IActionResult Weddingbuild()
        {
            return View("Weddingbuild");
        }
        [Route("AddWedding")]
        [HttpPost]
        public IActionResult AddWedding(Plan newWedding)
        {
            if (ModelState.IsValid)
            {
            // newWedding.Planner= (int)HttpContext.Session.GetInt32("UserId");
            _context.weddPlans.Add(newWedding);
            _context.SaveChanges();
            return RedirectToAction("DisplayedWeddings", new { id = newWedding.PlanId });
            }
            return View("Weddingbuild");
        }
// Shows The weddings dates after making a date
        [Route("DisplayedWeddings")]
        [HttpGet]
        public IActionResult DisplayedWeddings()
        {
            return View("DisplayedWeddings");
        }
        [Route("DisplayedWeddings/{id}")]
        [HttpGet]
        public IActionResult DisplayedWeddings(int id)
        {
            // List<User> AllUsers = _context.Users.ToList();
            // ViewBag.Users = AllUsers;
            Plan theWedding = _context.weddPlans
            .Include(l => l.GuestList)
            .ThenInclude(b => b.User)
            .FirstOrDefault(q => q.PlanId == id);
            return View("DisplayedWeddings", theWedding);
        }
// This controls those who RSVP and Adds and Delete
        [Route("AddRsvp")]
        [HttpPost]
        public IActionResult AddRsvp(RSVP newRSVP, int id)
        {
            newRSVP.WeddPlanId = (int)id;
            // newRSVP.UserId = (int)HttpContext.Session.GetInt32("UserId");
            // _context.rsvps.Add(newRSVP);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
        [Route("RemoveRsvp")]
        [HttpPost]
        public IActionResult RemoveRsvp(int id)
        {
            IEnumerable<RSVP> guests = _context.rsvps.Where(a => a.WeddPlanId == id);
            // RSVP Delete = guests.SingleOrDefault(user => user.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            // _context.rsvps.Remove(Delete);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
// This deletes the plan 
        // [Route("Delete")]
        // [HttpPost]
        // public IActionResult Delete(int id)
        // {
        //     Plan RetrievedWedding = _context.weddPlans.SingleOrDefault(w => w.PlanId == id);
        //     _context.weddPlans.Remove(RetrievedWedding);
        //     _context.SaveChanges();
        //     return RedirectToAction("Dashboard");
        // }
        [Route("Delete/{id}")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Plan RetrievedWedding = _context.weddPlans.SingleOrDefault(w => w.PlanId == id);
            // _context.weddPlans.Remove(RetrievedWedding);
            // _context.weddPlans.Remove(RetrievedWedding);

            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
// This is the Logout out of the dashboard
        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
    }
}
