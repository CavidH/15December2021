using Microsoft.AspNetCore.Mvc;

namespace _15December2021.Contollers
{
    public class Contact : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();  
        }
    }
}