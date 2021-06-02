using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Project.Controllers
{    
    public class LoginController : Controller
    {
        IAdminService _adminService;
        public LoginController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LoginPage()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginPage(Admin admin)
        {
            var information = _adminService.GetAdmin(admin);
            if (information!=null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,admin.User)
                };
                var userIdentity = new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Department");
            }
            return View();
        }
    }
}
