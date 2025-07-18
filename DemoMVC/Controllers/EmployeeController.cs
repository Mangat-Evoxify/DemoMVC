using AutoMapper;
using DemoMVC.Data;
using DemoMVC.Entities;
using DemoMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public EmployeeController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GetEmployees()
        {
            var data = _context.Employees.ToList();
            return Json(data);
        }

        [HttpPost]
        public IActionResult Create(EmployeeViewModel employeeVm)
        {
            if (ModelState.IsValid)
            {
                var employee = _mapper.Map<Employee>(employeeVm);
                _context.Employees.Add(employee);
                _context.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }

        [HttpPost]
        public IActionResult Update(EmployeeViewModel employeeVm)
        {
            var employee = _mapper.Map<Employee>(employeeVm);
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var emp = _context.Employees.Find(id);
            if (emp != null)
            {
                _context.Employees.Remove(emp);
                _context.SaveChanges();
                return Json(new { success = true });
            }
            return Json(new { success = false });
        }
    }
}
