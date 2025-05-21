using LdtLesson05.Models.Data_Models;
using Microsoft.AspNetCore.Mvc;

namespace LdtLesson05.Controllers
{
    public class LdtMemberController : Controller
    {
        private static List<LdtMember> ldtListMember = new List<LdtMember>()
        {
            new LdtMember
    {
        LdtMemberId = "M001",
        LdtUseerName = "john123",
        LdtPassWord = "pass1",
        LdtFullName = "John Doe",
        LdtEmail = "john@example.com"
    },
    new LdtMember
    {
        LdtMemberId = "M002",
        LdtUseerName = "jane456",
        LdtPassWord = "pass2",
        LdtFullName = "Jane Smith",
        LdtEmail = "jane@example.com"
    },
    new LdtMember
    {
        LdtMemberId = "M003",
        LdtUseerName = "david789",
        LdtPassWord = "pass3",
        LdtFullName = "David Johnson",
        LdtEmail = "david@example.com"
    },
    new LdtMember
    {
        LdtMemberId = "M004",
        LdtUseerName = "alice321",
        LdtPassWord = "pass4",
        LdtFullName = "Alice Brown",
        LdtEmail = "alice@example.com"
    },
    new LdtMember
    {
        LdtMemberId = "M005",
        LdtUseerName = "bob999",
        LdtPassWord = "pass5",
        LdtFullName = "Bob White",
        LdtEmail = "bob@example.com"
    }
        };

        public string LdtMemberId { get; internal set; }
        public string LdtUseerName { get; internal set; }
        public string LdtPassWord { get; internal set; }
        public string LdtFullName { get; internal set; }
        public string LdtEmail { get; internal set; }

        public IActionResult LdtIndex()
        {
            return View(ldtListMember);
        }
    }
}
