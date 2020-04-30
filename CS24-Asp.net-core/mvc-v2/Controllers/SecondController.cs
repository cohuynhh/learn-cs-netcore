using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mvc_v2.Controllers
{
    public class SecondController : Controller
    {
        private readonly ILogger<SecondController> _logger;

        public SecondController(ILogger<SecondController> logger)
        {
            _logger = logger;
        }

        [Route("/test-action1")]
        public IActionResult Action1()
        {
            return View();
        }

    }
}