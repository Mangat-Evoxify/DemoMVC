using DemoMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        //[HttpGet]
        //public IActionResult GetEmployees()
        //{
        //    var data = _context.Employees.ToList();
        //    return Json(data);
        //}

        //[HttpPost]
        //public IActionResult Create(EmployeeViewModel employee)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Employees.Add(employee);
        //        _context.SaveChanges();
        //        return Json(new { success = true });
        //    }
        //    return Json(new { success = false });
        //}

        //[HttpPost]
        //public IActionResult Update(EmployeeViewModel employee)
        //{
        //    _context.Employees.Update(employee);
        //    _context.SaveChanges();
        //    return Json(new { success = true });
        //}

        //[HttpPost]
        //public IActionResult Delete(int id)
        //{
        //    var emp = _context.Employees.Find(id);
        //    if (emp != null)
        //    {
        //        _context.Employees.Remove(emp);
        //        _context.SaveChanges();
        //        return Json(new { success = true });
        //    }
        //    return Json(new { success = false });
        //}
    }
}
