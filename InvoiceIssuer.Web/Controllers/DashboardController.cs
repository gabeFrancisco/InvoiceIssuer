using System;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Web.Sessions;
using InvoiceIssuer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceIssuer.Web.Controllers
{
    public class DashboardController : Controller
    {
        private readonly LoginStorage _loginStorage;
        private readonly IProviderRepository _providerRepository;
        private readonly IAddressRepository _addressRepository;
        public DashboardController(LoginStorage loginStorage,
                                   IProviderRepository providerRepository,
                                   IAddressRepository addressRepository)
        {
            _loginStorage = loginStorage;
            _providerRepository = providerRepository;
            _addressRepository = addressRepository;
        }
        [HttpGet]
        public async Task<IActionResult> Info()
        {
            try
            {
                Provider provider = _loginStorage.GetProvider();
                provider.Address = await _addressRepository.Read(provider.AddressId);

                DashInformationViewModel dashInformationViewModel = new DashInformationViewModel()
                {
                    Provider = provider
                };

                return View(dashInformationViewModel);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Invoices()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {
                return null;
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