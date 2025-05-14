using Lesson04.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson04.Controllers
{
    public class LdtBookController : Controller
    {
        List<LdtBook> ldtBook = new List<LdtBook>
{
    new LdtBook
    {
        LdtID = "B001",
        LdtTitle = "Cái gì đấy ",
        LdtDesciption = "A comprehensive guide to learning C# for beginners.",
        LdtImage = "/images/1.jpg",
        LdtPrice = "19.99",
        LdtPage = "320"
    },
    new LdtBook
    {
        LdtID = "B002",
        LdtTitle = "My Hero Academy",
        LdtDesciption = "Advanced concepts and real-world projects with ASP.NET Core.",
        LdtImage = "/images/2.jpg",
        LdtPrice = "29.99",
        LdtPage = "450"
    },
    new LdtBook
    {
        LdtID = "B003",
        LdtTitle = "jujutsu kaisen",
        LdtDesciption = "Learn data access in .NET using Entity Framework Core.",
        LdtImage = "/images/3.jpg",
        LdtPrice = "24.99",
        LdtPage = "380"
    },
    new LdtBook
    {
        LdtID = "B004",
        LdtTitle = "attack on titan",
        LdtDesciption = ".",
        LdtImage = "/images/4.jpg",
        LdtPrice = "22.50",
        LdtPage = "310"
    },
    new LdtBook
    {
        LdtID = "B005",
        LdtTitle = "Dragon Balls Super",
        LdtDesciption = ".",
        LdtImage = "/images/5.jpg",
        LdtPrice = "27.99",
        LdtPage = "400"
    }
};


        public IActionResult LdtIndex()
        {
            return View(ldtBook);
        }
    }
}
