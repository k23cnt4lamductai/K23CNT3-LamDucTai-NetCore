using System.Diagnostics;
using Lesson09.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson09.Controllers
{
    public class LdtHomeController : Controller
    {
        private readonly ILogger<LdtHomeController> _logger;

        public LdtHomeController(ILogger<LdtHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult LdtIndex()
        {
            return View();
        }

        public IActionResult LdtAbout()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
