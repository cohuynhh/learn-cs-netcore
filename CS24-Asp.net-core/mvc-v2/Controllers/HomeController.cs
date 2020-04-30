using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using mvc_v1.Models;

namespace mvc_v1.Controllers
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
            ViewBag.dulieu1 = "Đây là dữ liệu 1";
            ViewBag.dulieu2 = 12345;

            List<string> sanpham = new List<string>(){
                "Bàn ăn",
                "Giường ngủ",
                "Tủ áo"
            };

            return View(sanpham);
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

        public string XinChao() => "Xin chào ASP.NET Core 3.0";

        public IActionResult GetContent() 
        {  
           string contentType =  "text/plain";                   // mime - tham khảo https://en.wikipedia.org/wiki/Media_type
           string content = "Đây là nội dung file văn bản";
           return Content(content, contentType, Encoding.UTF8);  //Content(content, contentType);  - có thể bỏ Endcoding
        }

        public IActionResult GetJson()
        {
            return Json(
                new {
                    key1 = 100,
                    key2 = new string[] {"a", "b",  "c"}
                }
            );
        }

        public IActionResult TestRedirect()
        {
            return Redirect("https://xuanthulab.net");                             // Redirect 302 - chuyển hướng sang URL khác
            // return RedirectToRoute(new {controller="Home", action="Index"});    // Redirect 302 - Found
            // return RedirectPermanent("https://xuanthulab.net");                 // Redirect 301 - chuyển hướng URL khác
            // return RedirectToAction("Index");                                   // Chuyển hướng sang Action khác
        }

        public IActionResult FileAnh()
        {
            string filepath = "logo.png";
            return File(filepath, "image/png");
        }

        public IActionResult KhongCoGi()
        {
            return NotFound(
                "Trang không thấy"
            ); 
        }

        public IActionResult Sum(int x,  int y) 
        {
            return Content((x+y).ToString(), "text/plain", Encoding.UTF8);
        }

    }
 
}
