using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Ldt_Day5Model.Models;
using Ldt_Day5Model.Models.DataModels;

namespace Ldt_Day5Model.Controllers
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
            var Ldtmember = new LdtMember(); // Ensure LdtMember is defined in the Ldt_Day5Model.Models namespace
            Ldtmember.LdtMemberId = Guid.NewGuid().ToString();
            Ldtmember.LdtUserName = "Tùng";
            Ldtmember.LdtFullName = "Trần Thanh Tùng";
            Ldtmember.LdtPassword = "123456";
            Ldtmember.LdtEmail = "tung@gmail.com";
            return View(Ldtmember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
