using System;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Web.Sessions;
using InvoiceIssuer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InvoiceIssuer.Web.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly LoginStorage _loginStorage;
        private readonly IProviderRepository _providerRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IServiceTypeRepository _serviceTypeRepository;
        public InvoicesController(LoginStorage loginStorage,
                                   IProviderRepository providerRepository,
                                   IAddressRepository addressRepository,
                                   IInvoiceRepository invoiceRepository,
                                   IServiceTypeRepository serviceTypeRepository)
        {
            _loginStorage = loginStorage;
            _providerRepository = providerRepository;
            _addressRepository = addressRepository;
            _invoiceRepository = invoiceRepository;
            _serviceTypeRepository = serviceTypeRepository;
        }
        [HttpGet]

        [HttpGet]
        public async Task<IActionResult> List()
        {
            try
            {
                InvoicesViewModel invoicesViewModel = new InvoicesViewModel();
                invoicesViewModel.Invoices = await _invoiceRepository.GetByProvider(_loginStorage.GetProvider().Id);
                return View(invoicesViewModel);
            }
            catch (Exception)
            {
                return null;
            }
        }

        [HttpGet]
        public async Task<IActionResult> New()
        {
            InvoicesViewModel invoicesViewModel = new InvoicesViewModel()
            {
                ServiceTypes = await _serviceTypeRepository.GetAll()
            };

            return View(invoicesViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> New([FromForm] InvoicesViewModel invoicesViewModel)
        {
            //TODO - Persist invoice in the db
            return RedirectToAction("New", "Invoices");
        }
    }
}