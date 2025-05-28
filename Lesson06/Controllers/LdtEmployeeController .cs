using Lesson06.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson06.Controllers
{
    public class LdtEmployeeController : Controller
    {
        private static List<LdtEmployee>ldtListEmployee = new List<LdtEmployee>()
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
            
        public IActionResult LdtIndex()
        {
            return View(ldtListEmployee);
        }

    [HttpGet]
        public IActionResult LdtCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LdtCreateSubmit(LdtEmployee emp)
        {
            emp.LdtId =ldtListEmployee.Max(e => e.LdtId) + 1;
           ldtListEmployee.Add(emp);
            return RedirectToAction("LdtIndex");
        }

        [HttpGet]
        public IActionResult LdtEdit(int id)
        {
            var emp =ldtListEmployee.FirstOrDefault(e => e.LdtId == id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult LdtEditPUT(LdtEmployee updatedEmp)
        {
            var emp =ldtListEmployee.FirstOrDefault(e => e.LdtId == updatedEmp.LdtId);
            if (emp != null)
            {
                emp.LdtName = updatedEmp.LdtName;
                emp.LdtBirthDay = updatedEmp.LdtBirthDay;
                emp.LdtEmail = updatedEmp.LdtEmail;
                emp.LdtPhone = updatedEmp.LdtPhone;
                emp.LdtSalary = updatedEmp.LdtSalary;
                emp.LdtStatus = updatedEmp.LdtStatus;
            }
            return RedirectToAction("LdtIndex");
        }

        public IActionResult LdtDelete(int id)
        {
            var emp =ldtListEmployee.FirstOrDefault(e => e.LdtId == id);
            if (emp != null)ldtListEmployee.Remove(emp);
            return RedirectToAction("LdtIndex");
        }
    }
}
    
