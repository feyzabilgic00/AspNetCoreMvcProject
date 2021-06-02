using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class DepartmentController : Controller
    {
        IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var result = _departmentService.GetAll();
            return View(result);
        }
        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
             _departmentService.Add(department);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult UpdateDepartment(Department department)
        {
            _departmentService.Update(department);
            return RedirectToAction("Index",department);
        }     
        public IActionResult DeleteDepartment(int id)
        {
            Department department = _departmentService.GetById(id);
            //dep var mı kontrolü yap
            _departmentService.Delete(department);
            return RedirectToAction("Index",department);
        }
        public IActionResult BringDepartment(int id)
        {
            Department department=_departmentService.GetById(id);
            return View("BringDepartment",department);
        }
        public IActionResult DetailDepatment(int id)
        {
            var result = _departmentService.GetDepartmentsDetails(id);
            var departmentName = _departmentService.GetById(id).DepartmentName;
            ViewBag.departmentName = departmentName;
            return View(result);
        }
    }
}
