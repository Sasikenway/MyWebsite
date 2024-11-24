using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            // Add some dummy data or real contact data here
            ViewBag.Contacts = new List<string> { "John Doe", "Jane Smith", "Mike Johnson" };

            return View();
        }
    }
}
