using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloMVCWorld.Controllers
{
    [Route("/product")]
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Product overview");
        }

        //public IActionResult List()
        //{
        //    return Content("Product list");
        //}

        [Route("{id}")]
        [Route("/products/{id}")]
        public IActionResult Details(int id)
        {
            return Content("Product etails for #" + id);
        }
    }
}
