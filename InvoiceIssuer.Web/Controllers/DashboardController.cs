using System;
using InvoiceIssuer.Web.Sessions;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceIssuer.Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly LoginStorage _loginStorage;
        public DashboardController(LoginStorage loginStorage)
        {
            _loginStorage = loginStorage;
        }
        [HttpGet]
        public IActionResult Info()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public IActionResult Logout()
        {
            if (_loginStorage.GetProvider() != null)
            {
                _loginStorage.Exit();
                TempData["Logout"] = "Signed out successfully from the system!";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
    }
}