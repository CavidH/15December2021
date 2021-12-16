using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _15December2021.Contollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag.name = "Cavid";
            //ViewBag.surname = "Haciyev";
            return View();
        }
    }
}
