using DemoAuthentication_MVC_.Models;
using DemoAuthentication_MVC_.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DemoAuthentication_MVC_.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [Authorize(Policy = "readonly")]
        public IActionResult Index()
        {
            var emp = _employeeService.Get();
            return View(emp);
        }
        [Authorize(Policy = "writeonly")]
        public IActionResult Create()
        {
            return View(new EmployeeViewModel());
        }
        [HttpPost]
        public IActionResult Create(EmployeeViewModel emp)
        {
            var emps = _employeeService.Create(emp);
            return View("Index", emps);
        }
    }
}
