using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;
using InvoiceIssuer.Services.Sessions;
using InvoiceIssuer.Web.Filters;
using InvoiceIssuer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvoiceIssuer.Web.Controllers
{
    [UserAuthorizationAttribute]
    public class InvoicesController : Controller
    {
        private readonly IInvoiceService _invoiceService;
        private readonly LoginStorage _loginStorage;
        private readonly IProviderRepository _providerRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IServiceTypeRepository _serviceTypeRepository;
        private readonly ICompanyTypeRepository _companyTypeRepository;
        private readonly ITakerRepository _takerRepository;
        public InvoicesController(IInvoiceService invoiceService,
                                    ITakerService takerService,
                                    LoginStorage loginStorage,
                                    IProviderRepository providerRepository,
                                    IAddressRepository addressRepository,
                                    IInvoiceRepository invoiceRepository,
                                    IServiceTypeRepository serviceTypeRepository,
                                    ICompanyTypeRepository companyTypeRepository,
                                    ITakerRepository takerRepository)
        {
            _invoiceService = invoiceService;
            _loginStorage = loginStorage;
            _providerRepository = providerRepository;
            _addressRepository = addressRepository;
            _invoiceRepository = invoiceRepository;
            _serviceTypeRepository = serviceTypeRepository;
            _companyTypeRepository = companyTypeRepository;
            _takerRepository = takerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            return View(new InvoicesViewModel
            {
                Invoices = await _invoiceService.GetAll()
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetInvoice(Guid invoiceGuid)
        {
            return View("Preview", await _invoiceService.ReadInvoice(invoiceGuid));
        }     

        //TODO - Separate services
        [HttpGet]
        public async Task<IActionResult> New()
        {
            InvoicesViewModel invoicesViewModel = new InvoicesViewModel()
            {
                ServiceTypes = await _serviceTypeRepository.GetAll(),
                CompanyTypes = await _companyTypeRepository.GetAll()
            };

            return View(invoicesViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> New([FromForm] InvoicesViewModel invoicesViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            Invoice invoice = await _invoiceService.CreateInvoice(
                invoicesViewModel.Invoice,
                invoicesViewModel.Taker,
                invoicesViewModel.Address
            );

            return View("Preview", invoice);
        }

        //TODO - Change to API and separate to service
        [HttpGet]
        public async Task<IActionResult> GetProviderTotalIncome()
        {
            IEnumerable<Invoice> invoices = await _invoiceRepository.GetByProvider(_loginStorage.GetProvider().Id);
            decimal income = invoices.Sum(x => x.TotalValue);

            return Json(income);
        }

        [HttpGet]
        public async Task<IActionResult> Invoice([FromQuery] Guid invoiceGuid)
        {
            InvoicesViewModel invoicesViewModel = new InvoicesViewModel();

            invoicesViewModel.ServiceTypes = await _serviceTypeRepository.GetAll();
            invoicesViewModel.CompanyTypes = await _companyTypeRepository.GetAll();

            Invoice invoice = await _invoiceService.ReadInvoice(invoiceGuid);
            invoicesViewModel.Invoice = invoice;

            Taker taker = await _takerRepository.GetByCI(invoice.Taker.CI);
            invoicesViewModel.Taker = taker;
            invoicesViewModel.Address = taker.Address;
            decimal totalValue = invoice.TotalValue;

            return View(invoicesViewModel);
        }

        [HttpGet]
        public async Task<IActionResult> Update(Guid invoiceGuid)
        {
            InvoicesViewModel invoicesViewModel = new InvoicesViewModel();

            invoicesViewModel.ServiceTypes = await _serviceTypeRepository.GetAll();
            invoicesViewModel.CompanyTypes = await _companyTypeRepository.GetAll();

            Invoice invoice = await _invoiceRepository.Read(invoiceGuid);
            invoicesViewModel.Invoice = invoice;

            Taker taker = await _takerRepository.GetByCI(invoice.Taker.CI);
            invoicesViewModel.Taker = taker;
            invoicesViewModel.Address = taker.Address;
            decimal totalValue = invoice.TotalValue;

            return View(invoicesViewModel);
        }

        // [HttpPost]
        // public async Task<IActionResult> Update([FromForm] InvoicesViewModel invoicesViewModel)
        // {
        //     try
        //     {
        //         Invoice invoice = await HandleInvoice(invoicesViewModel, "Update");
        //         invoicesViewModel.Provider = invoice.Provider;
        //         invoicesViewModel.Taker = invoice.Taker;
        //         invoicesViewModel.Invoice = invoice;
        //         return View("Invoice", invoicesViewModel);
        //     }
        //     catch (Exception ex)
        //     {
        //         return BadRequest(ex);
        //     }
        // }
    }
}