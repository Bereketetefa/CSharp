using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Login2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;


namespace Login.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context { get; set; } 
        public HomeController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("Register")]
        public IActionResult Register(User newuser)
            {
                if(ModelState.IsValid)
                {
                User userMatchingEmail = _context.UsersInfo
                .FirstOrDefault(u => u.email == newuser.email);
                if(userMatchingEmail != null)
                {
                ModelState.AddModelError("Email", "Email already in use!");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    newuser.password = Hasher.HashPassword(newuser, newuser.password);
                    _context.UsersInfo.Add(newuser);
                    _context.SaveChanges();
                    HttpContext.Session.SetInt32("UserID", newuser.UserId);
                    return Redirect("/Success");
                    }
                }
                return View("Index");
            }



        [HttpGet("Login")]  
        public IActionResult Login(LoginUser user)
        {
            return View("Login");
        }
        [HttpPost("Success")]
        public IActionResult Success(LoginUser user)
        {
            if(ModelState.IsValid)
            {
            User userMatchingEmail = _context.UsersInfo
            .FirstOrDefault(u => u.email == user.email);
            if(userMatchingEmail != null)
            {
            ModelState.AddModelError("Email", "Email already in use!");
            }
            else
            {
            var hasher = new PasswordHasher<LoginUser>();
            var result = hasher.VerifyHashedPassword(user, userMatchingEmail.password, user.password);
            if(result == 0)
            {
                ModelState.AddModelError("password", "incorrect Password!");
                }
                else{
                HttpContext.Session.SetInt32("UserId", userMatchingEmail.UserId);
                return Redirect("/Success");
                    }
                }
            }
            return View("Success");
        }
        




        [HttpGet("Success")]
        public IActionResult Success()
        {
            int? UserID = HttpContext.Session.GetInt32("UserID");
            if(UserID == null)
            {
            return Redirect("/");
            }
            else
            {
            ViewBag.UserID = (int) UserID;
            ViewBag.User = _context.UsersInfo.FirstOrDefault(u => u.UserId ==(int)UserID); 
            return View("Success");
            }
        }
    }
}


    
        // [HttpPost("send")]
        // public IActionResult send(User newbie)
        // {
        //     // if(ModelState.IsValid)
        //     // {
        //         _context.UsersInfo.Add(newbie);
        //         _context.SaveChanges();
        //         return Redirect("/Login");
        //     // }
        //     // else
        //     // {
        //     //     return View("Index");
        //     // }
        // }

        // [HttpPost("Login")]
        // public IActionResult Login()
        // {
        //     List<User> dishes = _context.UsersInfo.ToList();
        //     IEnumerable<User> meals = dishes.OrderByDescending(a => a.first_name);
        //     return View(dishes);
        // }
  
