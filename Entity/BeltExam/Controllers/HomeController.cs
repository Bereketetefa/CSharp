using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BeltExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Dojo_Activity.Controllers
{
    public class HomeController : Controller
    { private MyContext _context { get; set; }
        public HomeController(MyContext context)
        {
        _context = context;
        }
// Registrartion work starts here
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
// Registration work starts here
        [HttpPost]
        [Route("Register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (_context.users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.users.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetString("LoggedIn", "LoggedIn");
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                var userInDb = _context.users.FirstOrDefault(u => u.Email == newUser.Email);
                return RedirectToAction("Home");
            }
            else
            {
                return View("Index");
            }
        }
// Login work starts here
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
                var userInDb = _context.users.FirstOrDefault(u => u.Email == user.LoginEmail);
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
                return RedirectToAction("Home");
            }
            else
            {
                return View("Index");
            }
        }
// Logout work starts here
        [Route("logout")]
        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }
// Home(Dashboard) starts here
        [Route("Home")]
        [HttpGet]
        public IActionResult Home(User currUser)
        {
            if (HttpContext.Session.GetString("LoggedIn") == null)
            {
                return RedirectToAction("Index");
            }
            IEnumerable<Activities> AllActivities = _context.activities
            .Include(r => r.JoinList)
            .ThenInclude(u => u.User)
            .ToList()
            .OrderBy(c => c.ActivityDate);

            List<User> Allusers = _context.users
            .ToList();
            ViewBag.AllUsers = Allusers;
            ViewBag.currUser = currUser;
            ViewBag.activities = AllActivities;
        
            User user = _context.users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            ViewBag.name = user;
            ViewBag.User = (int)HttpContext.Session.GetInt32("UserId");
            return View();
        }
//This Creates an Activity
        [Route("Activitybuild")]
        [HttpGet]
        public IActionResult Activitybuild()
        {
            if (HttpContext.Session.GetString("LoggedIn") == null)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
        [Route("addActivity")]
        [HttpPost]
        public IActionResult addActivity(Activities newActivity)
        {
            if (ModelState.IsValid)
            {
                newActivity.ActivityPlanner = (int)HttpContext.Session.GetInt32("UserId");
                // newActivity.ActivityPlanner = (int)HttpContext.Session.GetInt32("UserId");
                _context.activities.Add(newActivity);
                _context.SaveChanges();
                return RedirectToAction("CreatedActivity", new { id = newActivity.ActivitiyId });
            }
            return View("createdActivity");
        }
// Display Activities 
        [Route("CreatedActivity/{id}")]
        [HttpGet]
        public IActionResult CreatedActivity(int id)
        {
            if (HttpContext.Session.GetString("LoggedIn") == null)
            {
                return RedirectToAction("Index");
            }
            Activities theActivity = _context.activities
            .Include(j => j.JoinList)
            .ThenInclude(u => u.User)
            .FirstOrDefault(w => w.ActivitiyId == id);
            ViewBag.theActivity = theActivity;

            List<Activities> AllActivities = _context.activities
            .Include(r => r.JoinList)
            .ThenInclude(u => u.User)
            .ToList();

            List<User> Allusers = _context.users
            .ToList();
            ViewBag.AllUsers = Allusers;

            User user = _context.users.FirstOrDefault(a => a.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            ViewBag.name = user;
            ViewBag.activities = AllActivities;
            ViewBag.User = (int)HttpContext.Session.GetInt32("UserId");
            return View("CreatedActivity", theActivity);
        }
// Join Activity
        [Route("join/{id}/{uid}")]
        [HttpPost]
        public IActionResult Join(Join newJoin, int id, int uid)
        {

            Activities newActive = _context.activities.Include(a => a.JoinList)
            .ThenInclude(b => b.User)
            .FirstOrDefault(x => x.ActivitiyId == id);
            
            User newUser = _context.users
            .Include(a => a.Atending)
            .ThenInclude(b => b.Active)
            .FirstOrDefault(us => us.UserId == uid);
            foreach (var joined in newUser.Atending)
            {
                if (joined.Active.ActivityDate.Date == newActive.ActivityDate.Date)
                {
                    ModelState.AddModelError("ActivityDate", "Date Cannot be in the past");
                    return RedirectToAction("Home", new { id = (int)HttpContext.Session.GetInt32("UserId") });
                }
            }

            newJoin.ActivitiyId = (int)id;
            // newJoin.UserId = (int)HttpContext.Session.GetInt32("UserId");
            newJoin.UserId = uid;
            _context.joinTable.Add(newJoin);
            _context.SaveChanges();
            return RedirectToAction("Home");
        }
// Leave an activity Starts here
        [Route("leave/{id}")]
        [HttpPost]
        public IActionResult Leave(int id)
        {
            IEnumerable<Join> attendee = _context.joinTable
            .Where(a => a.ActivitiyId == id);
            Join flaker = attendee
            .SingleOrDefault(user => user.UserId == (int)HttpContext.Session.GetInt32("UserId"));
            _context.joinTable
            .Remove(flaker);
            _context.SaveChanges();
            return RedirectToAction("Home");
        }

// Delete for User Starts here
        [Route("delete/{id}")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            Activities RetrievedActivity = _context.activities.SingleOrDefault(w => w.ActivitiyId == id);
            _context.activities.Remove(RetrievedActivity);
            _context.SaveChanges();
            return RedirectToAction("Home");
        }
    }
}