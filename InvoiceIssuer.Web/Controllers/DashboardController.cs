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
            return View();
        }

        public IActionResult Logout()
        {
            _loginStorage.Exit();
            TempData["Logout"] = "Signed out successfully from the system!";
            return RedirectToAction("Index", "Home");
        }
    }
}