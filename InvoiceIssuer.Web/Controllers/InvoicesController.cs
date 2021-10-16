using System;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Web.Sessions;
using InvoiceIssuer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace InvoiceIssuer.Web.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly LoginStorage _loginStorage;
        private readonly IProviderRepository _providerRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IServiceTypeRepository _serviceTypeRepository;
        private readonly ICompanyTypeRepository _companyTypeRepository;
        public InvoicesController(LoginStorage loginStorage,
                                   IProviderRepository providerRepository,
                                   IAddressRepository addressRepository,
                                   IInvoiceRepository invoiceRepository,
                                   IServiceTypeRepository serviceTypeRepository,
                                   ICompanyTypeRepository companyTypeRepository)
        {
            _loginStorage = loginStorage;
            _providerRepository = providerRepository;
            _addressRepository = addressRepository;
            _invoiceRepository = invoiceRepository;
            _serviceTypeRepository = serviceTypeRepository;
            _companyTypeRepository = companyTypeRepository;
        }

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
            try
            {
                InvoicesViewModel invoicesViewModel = new InvoicesViewModel()
                {
                    ServiceTypes = await _serviceTypeRepository.GetAll(),
                    CompanyTypes = await _companyTypeRepository.GetAll()
                };

                return View(invoicesViewModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public async Task<IActionResult> New([FromForm] InvoicesViewModel invoicesViewModel)
        {
            try
            {
                Invoice invoice = new Invoice()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    Date = DateTime.UtcNow
                };

                var invoices = await _invoiceRepository.GetByProvider(_loginStorage.GetProvider().Id);

                //Get invoices list lenght for numbering
                invoice.Number = invoices.Where(x => x.Date.Year.Equals(DateTime.UtcNow.Year)).Count() + 1;
                invoice.Provider = await _providerRepository.GetByCI(_loginStorage.GetProvider().CI);
                invoice.Title = invoicesViewModel.Title;
                invoice.Description = invoicesViewModel.Description;
                invoice.Taker = new Taker()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    CI = invoicesViewModel.Taker.CI,
                    ComercialName = invoicesViewModel.Taker.ComercialName,
                    Phone = invoicesViewModel.Taker.Phone,
                    Email = invoicesViewModel.Taker.Email,

                    //Get company type name by searching the string of viewModel
                    CompanyType = await _companyTypeRepository.GetByName(invoicesViewModel.CompanyType),
                    Address = new Address()
                    {
                        Id = Guid.NewGuid(),
                        CreatedAt = DateTime.UtcNow,
                        Road = invoicesViewModel.Address.Road,
                        Number = invoicesViewModel.Address.Number,
                        Complement = invoicesViewModel.Address.Complement,
                        Block = invoicesViewModel.Address.Block,
                        City = invoicesViewModel.Address.City,
                        State = invoicesViewModel.Address.State,
                        PostalCode = invoicesViewModel.Address.PostalCode
                    },
                };

                invoice.ServiceType = await _serviceTypeRepository.GetByName(invoicesViewModel.ServiceType);
                invoice.TotalValue = invoicesViewModel.Price;
                invoice.TaxValue = 2.5M;

                await _invoiceRepository.Create(invoice);

                return RedirectToAction("List", "Invoices");
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}