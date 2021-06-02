using Business.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }        
        public IActionResult Index()
        {
            var result=_employeeService.GetEmployeeDetails();
            return View(result);
        }
        [HttpGet]
        public IActionResult NewAddEmployee()
        {
            //List<EmployeeDetailsDto> value = _employeeService.GetDepartments();            
            ViewBag.value = new SelectList(_employeeService.GetDepartments(),"DepartmentId","Department");
            return View();
        }
        [HttpPost]
        public IActionResult NewAddEmployee(Employee employee)
        {
            _employeeService.Add(employee);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEmployee(int id)
        {
            Employee employee = _employeeService.GetById(id);
            _employeeService.Delete(employee);
            return RedirectToAction("Index",employee);
        }
        public IActionResult BringEmployee(int id)
        {
            var result = _employeeService.GetById(id);
            ViewBag.value = new SelectList(_employeeService.GetDepartments(), "DepartmentId", "Department");
            return View("BringEmployee", result);
        }
        [HttpGet]
        public IActionResult UpdateEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.Update(employee);
            return RedirectToAction("Index", employee);
        }
    }
}
