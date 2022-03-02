using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;
using InvoiceIssuer.Services.Sessions;
using InvoiceIssuer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InvoiceIssuer.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly LoginStorage _loginStorage;
        private readonly IProviderRepository _providerRepository;
        private readonly IInvoiceService _invoiceService;

        public HomeController(LoginStorage loginStorage,
                              IProviderRepository providerRepository,
                              IInvoiceService invoiceService)
        {
            _loginStorage = loginStorage;
            _providerRepository = providerRepository;
            _invoiceService = invoiceService;
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

        [HttpPost]
        public async Task<IActionResult> SearchInvoice([FromForm] LoginViewModel viewModel)
        {
            if (viewModel.InvoiceGuid.Length < 36)
                return BadRequest("InvoiceGuid cannot be less than 36 characters");

            var invoice = await _invoiceService.ReadInvoice(Guid.Parse(viewModel.InvoiceGuid));

            if (invoice == null)
            {
                return new ContentResult { Content = "No invoices was found with the given GUID! " };
            }
            else
            {   
                return RedirectToAction("GetInvoice", "Invoices", new { invoiceGuid = invoice.Id });
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
