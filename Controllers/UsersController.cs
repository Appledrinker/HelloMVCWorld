using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    public class UsersController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.ClientSideUser clientUser)
        {
            if (ModelState.IsValid)
            {
                // Save the web user to the database, return a view that shows them successfully created, or redirect to another page
            }
            return View();
        }
    }
}
