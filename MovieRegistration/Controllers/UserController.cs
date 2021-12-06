using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieRegistration.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MovieRegistration.Controllers
{
    public class UserController : Controller
    {
        
        public IActionResult Index()
        {
            User model = new User();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(User model)
        {
            return RedirectToAction("Result", model);
        }

        public IActionResult User(User model)
        {
            return View(model);
        }

        public IActionResult Result(User model)
        {
            return View(model);
        }


        
    }
}
