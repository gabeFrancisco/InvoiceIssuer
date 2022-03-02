using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;
using InvoiceIssuer.Services.Sessions;
using InvoiceIssuer.Web.Filters;
using InvoiceIssuer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace InvoiceIssuer.Web.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly IInvoiceService _invoiceService;
        private readonly IServiceTypeService _serviceTypeService;
        private readonly ICompanyTypeService _companyTypeService;
        private readonly ITakerService _takerService;
        private readonly LoginStorage _loginStorage;
        public InvoicesController(IInvoiceService invoiceService,
                                  IServiceTypeService serviceTypeService,
                                  ICompanyTypeService companyTypeService,
                                  ITakerService takerService,
                                  LoginStorage loginStorage)
        {
            _invoiceService = invoiceService;
            _serviceTypeService = serviceTypeService;
            _companyTypeService = companyTypeService;
            _takerService = takerService;
            _loginStorage = loginStorage;
        }

        [UserAuthorizationAttribute]
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

        [UserAuthorizationAttribute]
        [HttpGet]
        public async Task<IActionResult> New()
        {
            InvoicesViewModel invoicesViewModel = new InvoicesViewModel()
            {
                ServiceTypes = await _serviceTypeService.GetAll(),
                CompanyTypes = await _companyTypeService.GetAll()
            };

            return View(invoicesViewModel);
        }

        [UserAuthorizationAttribute]
        [HttpPost]
        public async Task<IActionResult> New([FromForm] InvoicesViewModel invoicesViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            return View("Preview", await _invoiceService.CreateInvoice(
                invoicesViewModel.Invoice,
                invoicesViewModel.Taker,
                invoicesViewModel.Address
            ));
        }

        [UserAuthorizationAttribute]
        [HttpGet]
        public async Task<IActionResult> Invoice([FromQuery] Guid invoiceGuid)
        {
            InvoicesViewModel invoicesViewModel = new InvoicesViewModel();

            invoicesViewModel.ServiceTypes = await _serviceTypeService.GetAll();
            invoicesViewModel.CompanyTypes = await _companyTypeService.GetAll();

            Invoice invoice = await _invoiceService.ReadInvoice(invoiceGuid);
            invoicesViewModel.Invoice = invoice;

            Taker taker = await _takerService.ReadTaker(invoice.Taker.CI);
            invoicesViewModel.Taker = taker;
            invoicesViewModel.Address = taker.Address;
            decimal totalValue = invoice.TotalValue;

            return View(invoicesViewModel);
        }

        [UserAuthorizationAttribute]
        [HttpGet]
        public async Task<IActionResult> Update([FromQuery] Guid invoiceGuid)
        {
            InvoicesViewModel invoicesViewModel = new InvoicesViewModel();

            invoicesViewModel.ServiceTypes = await _serviceTypeService.GetAll();
            invoicesViewModel.CompanyTypes = await _companyTypeService.GetAll();

            Invoice invoice = await _invoiceService.ReadInvoice(invoiceGuid);
            invoicesViewModel.Invoice = invoice;

            Taker taker = await _takerService.ReadTaker(invoice.Taker.CI);
            invoicesViewModel.Taker = taker;
            invoicesViewModel.Address = taker.Address;
            decimal totalValue = invoice.TotalValue;

            return View(invoicesViewModel);
        }

        [UserAuthorizationAttribute]
        [HttpPost]
        public async Task<IActionResult> Update([FromForm] InvoicesViewModel invoicesViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest();
                
            return View("Preview", await _invoiceService.UpdateInvoice(invoicesViewModel.Invoice));
        }
    }
}