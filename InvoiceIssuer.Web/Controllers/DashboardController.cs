using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Web.Filters;
using InvoiceIssuer.Web.Sessions;
using InvoiceIssuer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InvoiceIssuer.Web.Controllers
{
    [UserAuthorizationAttribute]
    public class DashboardController : Controller
    {
        private readonly LoginStorage _loginStorage;
        private readonly IAddressRepository _addressRepository;
        public DashboardController(LoginStorage loginStorage,
                                   IAddressRepository addressRepository)
        {
            _loginStorage = loginStorage;
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
            catch (Exception ex)
            {
                return View("SessionError");
            }
        }

        [HttpGet]
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