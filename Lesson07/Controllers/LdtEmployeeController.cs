using Lesson07.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lesson07.Controllers
{
    public class LdtEmployeeController : Controller
    {   // Mock Data : 
        private static List<LdtEmployee> ldtListEmployee = new List<LdtEmployee>()
        {
            new LdtEmployee
             {
             LdtId = 1,
             LdtName = "Lâm Đức Tài",
             LdtBirthDay = new DateTime(2005, 9, 26),
             LdtEmail = "lamvietung1979@gmial.com",
             LdtPhone = "0338962005",
             LdtSalary = 12000000,
             LdtStatus = true
             },
             new LdtEmployee
             {
             LdtId = 2,
             LdtName = "Trần Thị B",
             LdtBirthDay = new DateTime(1992, 8, 22),
             LdtEmail = "b.tran@example.com",
             LdtPhone = "0902345678",
             LdtSalary = 13500000,
             LdtStatus = false
             },
             new LdtEmployee
             {
             LdtId = 3,
             LdtName = "Lê Văn C",
             LdtBirthDay = new DateTime(1985, 11, 2),
             LdtEmail = "c.le@example.com",
             LdtPhone = "0903456789",
             LdtSalary = 15000000,
             LdtStatus = true
             },
             new LdtEmployee
             {
             LdtId = 4,
             LdtName = "Phạm Thị D",
             LdtBirthDay = new DateTime(1996, 3, 18),
             LdtEmail = "d.pham@example.com",
             LdtPhone = "0904567890",
             LdtSalary = 9500000,
             LdtStatus = true
             },
             new LdtEmployee
             {
             LdtId = 5,
             LdtName = "Vũ Văn E",
             LdtBirthDay = new DateTime(1991, 7, 24),
             LdtEmail = "e.vu@example.com",
             LdtPhone = "0905678901",
             LdtSalary = 10500000,
             LdtStatus = false
             }
        };


        // GET: LdtEmployeeController
        public ActionResult LdtIndex()
        {
            return View(ldtListEmployee);
        }

        // GET: LdtEmployeeController/Details/5
        public ActionResult LdtDetails(int id)
        {
            var ldtEmployee = ldtListEmployee.FirstOrDefault(x => x.LdtId == id);
            return View(ldtEmployee);
        }

        // GET: LdtEmployeeController/Create
        public ActionResult LdtCreate()
        {
            var ldtEmployee = new LdtEmployee();
            return View();
        }

        // POST: LdtEmployeeController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LdtCreate(LdtEmployee ldtModel)
        {
            try
            {   //Thêm mới nhân viên vào List
                ldtModel.LdtId = ldtListEmployee.Max(x => x.LdtId) + 1;
                ldtListEmployee.Add(ldtModel);
                return RedirectToAction(nameof(LdtIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: LdtEmployeeController/Edit/5
        public ActionResult LdtEdit(int id)
        {
            var ldtEmployee = ldtListEmployee.FirstOrDefault(x => x.LdtId == id);
            return View(ldtEmployee);
        }

        // POST: LdtEmployeeController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LdtEdit(int id, LdtEmployee ldtModel)
        {
            try
            {
                for (int i = 0; i < ldtListEmployee.Count(); i++)
                    if (ldtListEmployee[i].LdtId == id)
                    {
                        ldtListEmployee[i] = ldtModel;
                        break;
                    }    
                return RedirectToAction(nameof(LdtIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: LdtEmployeeController/Delete/5
        public ActionResult LdtDelete(int id)
        {
            var ldtEmployee = ldtListEmployee.FirstOrDefault(x => x.LdtId == id);
            if (ldtEmployee == null) return NotFound();
            return View(ldtEmployee);
        }

        // POST: LdtEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult LdtDelete(int id, IFormCollection collection)
        {
            try
            {
                var ldtEmployee = ldtListEmployee.FirstOrDefault(x => x.LdtId == id);
                if (ldtEmployee != null)
                {
                    ldtListEmployee.Remove(ldtEmployee);
                }
                return RedirectToAction(nameof(LdtIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
