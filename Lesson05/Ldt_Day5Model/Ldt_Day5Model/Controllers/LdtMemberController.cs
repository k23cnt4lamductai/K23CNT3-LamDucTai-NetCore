using Microsoft.AspNetCore.Mvc;
using Ldt_Day5Model.Models.DataModels;

namespace LdtLesson05.Controllers
{
    public class LdtMemberController : Controller
    {
        private static List<LdtMember> LdtListMember = new List<LdtMember>()
        {
            new LdtMember
    {
        LdtMemberId = "2310900115",
        LdtUserName = "Tung",
        LdtPassword = "pass1234",
        LdtFullName = "Tran Thanh Tung",
        LdtEmail = "tung@gmail.com"
    },
    new LdtMember
    {
        LdtMemberId = "M002",
        LdtUserName = "jane456",
        LdtPassword = "pass2",
        LdtFullName = "Jane Smith",
        LdtEmail = "jane@example.com"
    },
    new LdtMember
    {
        LdtMemberId = "M003",
        LdtUserName = "david789",
        LdtPassword = "pass3",
        LdtFullName = "David Johnson",
        LdtEmail = "david@example.com"
    },
    new LdtMember
    {
        LdtMemberId = "M004",
        LdtUserName = "alice321",
        LdtPassword = "pass4",
        LdtFullName = "Alice Brown",
        LdtEmail = "alice@example.com"
    },
    new LdtMember
    {
        LdtMemberId = "M005",
        LdtUserName = "bob999",
        LdtPassword = "pass5",
        LdtFullName = "Bob White",
        LdtEmail = "bob@example.com"
    }
        };

        public string LdtMemberId { get; internal set; }
        public string LdtUserName { get; internal set; }
        public string LdtPassword { get; internal set; }
        public string LdtFullName { get; internal set; }
        public string LdtEmail { get; internal set; }

        public IActionResult LdtIndex()
        {
            return View(LdtListMember);
        }
    }
}
