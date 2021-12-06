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
    public class MovieController : Controller
    {

        public IActionResult Index()
        {
            Movie model = new Movie();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(Movie model)
        {
            return RedirectToAction("Result", model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Registration(Movie model)
        {
            return View(model);
        }
        public IActionResult Result(Movie model)
        {
            return View(model);
        }




    }
}
