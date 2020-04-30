using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mvc01.Models;

namespace Mvc01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string Hello() 
        {
            return "Xin chao ASP.NET Core 3.0";
        }
        public IActionResult ContentReturn()
        {
            return  Content("ContentReturn", "text/plain");
        }

        public IActionResult JsonDemo() 
        {
            var m = new {
            Id = 3,
            Text = "Grilled sausage with sauerkraut and potatoes", Price = 12.90,
            Date = new DateTime(2018, 3, 31),
            Category = "Main"
            };
            return Json(m); 
        }   

        public IActionResult FileDemo() => File("~/images/Matthias.jpg", "image/jpeg");

        public IActionResult ViewDemo() 
        {
            ViewBag.mgs = "Thông báo từ Controller";
            return View();
        }
    }
            
}

