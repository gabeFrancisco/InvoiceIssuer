using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Web.Sessions;
using InvoiceIssuer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InvoiceIssuer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoginStorage _loginStorage;
        private readonly IProviderRepository _providerRepository;

        public HomeController(LoginStorage loginStorage, IProviderRepository providerRepository)
        {
            _loginStorage = loginStorage;
            _providerRepository = providerRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            if (_loginStorage.GetProvider() != null)
            {
                return RedirectToAction("Info", "Dashboard");
            }
            
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index([FromForm] LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var provider = new Provider();
            provider = await _providerRepository.GetByCI(viewModel.CI);
            string hashPassword = HashEncrypt.GenerateHash(viewModel.Password);

            if (provider == null || hashPassword != provider.Password.ToLower())
            {
                ViewBag.Error = "CI or Password incorrect. Check again!";
                return View(nameof(Index));
            }

            else
            {
                _loginStorage.SignIn(provider);
                return RedirectToAction("Info", "Dashboard");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
