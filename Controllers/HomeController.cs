using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // return Content("Hello, MVC World!");
            Models.Movie movie = new Models.Movie()
            {
                Title = "The Godfather",
                ReleaseDate = new DateTime(1972, 3, 24)
            };
            return View(movie);
        }

        public IActionResult TestLayout()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View();
        }
    }
}
