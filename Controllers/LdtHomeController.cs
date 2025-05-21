using System.Diagnostics;
using LdtLesson05.Models;
using Microsoft.AspNetCore.Mvc;

namespace LdtLesson05.Controllers
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
            LdtMemberController ldtMember = new LdtMemberController();
            ldtMember.LdtMemberId = Guid.NewGuid().ToString();
            ldtMember.LdtUseerName = "Duc Tai";
            ldtMember.LdtPassWord = "123456";
            ldtMember.LdtFullName = "Lam Duc Tai";
            ldtMember.LdtEmail = "lamvietung1979@gmail.com";
            return View();


        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
