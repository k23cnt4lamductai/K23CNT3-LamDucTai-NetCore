using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Principal;

namespace Lesson08.Controllers
{
    public class LdtAccountController : Controller
    {
        public class LdtAccountController : Controller
        {
            private static List<LdtAccount> ldtListAccount = new List<LdtAccount>()
            {
            new LdtAccount
                {
                    LdtId = 230022113,
                    LdtFullName = "Lâm Đức Tài",
                    LdtEmail = "lamvietung1979@gmail.com",
                    LdtPhone = "0974326194",
                    LdtAddress = "Lớp K23CNT3",
                    LdtAvatar = "1.jpg",
                    LdtBirthday = new DateTime(2005, 09, 26),
                    LdtGender = "Nam",
                    LdtPassword = "123456789",
                    LdtFacebook = "https://www.facebook.com/lam.uc.tai.444516"
                },
                new LdtAccount
                {
                    LdtId = 2,
                    LdtFullName = "Trần Thị B",
                    LdtEmail = "tranthib@example.com",
                    LdtPhone = "0987654321",
                    LdtAddress = "456 Đường B, Quận 3, TP.HCM",
                    LdtAvatar = "avatar2.jpg",
                    LdtBirthday = new DateTime(1992, 8, 15),
                    LdtGender = "Nữ",
                    LdtPassword = "password2",
                    LdtFacebook = "https://facebook.com/tranthib"
                },
                new LdtAccount
                {
                    LdtId = 3,
                    LdtFullName = "Lê Văn C",
                    LdtEmail = "levanc@example.com",
                    LdtPhone = "0911222333",
                    LdtAddress = "789 Đường C, Quận 5, TP.HCM",
                    LdtAvatar = "avatar3.jpg",
                    LdtBirthday = new DateTime(1988, 12, 1),
                    LdtGender = "Nam",
                    LdtPassword = "password3",
                    LdtFacebook = "https://facebook.com/levanc"
                },
                new LdtAccount
                {
                    LdtId = 4,
                    LdtFullName = "Phạm Thị D",
                    LdtEmail = "phamthid@example.com",
                    LdtPhone = "0909876543",
                    LdtAddress = "321 Đường D, Quận 7, TP.HCM",
                    LdtAvatar = "avatar4.jpg",
                    LdtBirthday = new DateTime(1995, 3, 10),
                    LdtGender = "Nữ",
                    LdtPassword = "password4",
                    LdtFacebook = "https://facebook.com/phamthid"
                },
                new LdtAccount
                {
                    LdtId = 5,
                    LdtFullName = "Hoàng Văn E",
                    LdtEmail = "hoangvane@example.com",
                    LdtPhone = "0933444555",
                    LdtAddress = "654 Đường E, Quận 10, TP.HCM",
                    LdtAvatar = "avatar5.jpg",
                    LdtBirthday = new DateTime(1991, 7, 22),
                    LdtGender = "Nam",
                    LdtPassword = "password5",
                    LdtFacebook = "https://facebook.com/hoangvane"
                }
             };




            // GET: LdtAccountController
            public ActionResult Index()
        {
            return View();
        }

        // GET: LdtAccountController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LdtAccountController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LdtAccountController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LdtAccountController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LdtAccountController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LdtAccountController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LdtAccountController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
