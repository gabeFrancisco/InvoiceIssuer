using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Web.Sessions;
using InvoiceIssuer.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        private readonly ITakerRepository _takerRepository;
        public InvoicesController(LoginStorage loginStorage,
                                   IProviderRepository providerRepository,
                                   IAddressRepository addressRepository,
                                   IInvoiceRepository invoiceRepository,
                                   IServiceTypeRepository serviceTypeRepository,
                                   ICompanyTypeRepository companyTypeRepository,
                                   ITakerRepository takerRepository)
        {
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
            try
            {
                InvoicesViewModel invoicesViewModel = new InvoicesViewModel
                {
                    Invoices = await _invoiceRepository.GetByProvider(_loginStorage.GetProvider().Id)
                };
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

        [HttpGet]
        public async Task<IActionResult> GetInvoice([FromQuery] Guid invoiceGuid)
        {
            try
            {
                InvoicesViewModel viewModel = new InvoicesViewModel();
                Invoice invoice = await _invoiceRepository.Read(invoiceGuid);
                viewModel.Invoice = invoice;
                viewModel.Provider = _loginStorage.GetProvider();
                viewModel.Taker = await _takerRepository.Read(invoice.TakerId);

                return View("Invoice", viewModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
        [Route("/Invoices/GetTakerData/{companyIndex}")]
        public async Task<IActionResult> GetTakerData([FromRoute] string companyIndex)
        {

            Taker taker = await _takerRepository.GetByCI(companyIndex);
            return Json(taker);

        }

        [HttpGet]
        public async Task<IActionResult> GetProviderInvoiceHistory()
        {
            IEnumerable<Invoice> invoices = await _invoiceRepository.GetByProvider(_loginStorage.GetProvider().Id);
            List<int> monthList = new List<int>(new int[12]);
            for (int i = 0; i < monthList.Count(); i++)
            {
                monthList[i] = invoices.Where(x => x.Date.Month.Equals(i + 1)).Count();
            }
            return Json(monthList);
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
                    Date = invoicesViewModel.Date
                };

                var invoices = await _invoiceRepository.GetByProvider(_loginStorage.GetProvider().Id);

                //Get invoices list lenght for numbering
                invoice.Number = invoices.Where(x => x.Date.Year.Equals(DateTime.UtcNow.Year)).Count() + 1;
                invoice.Provider = await _providerRepository.GetByCI(_loginStorage.GetProvider().CI);
                invoice.Title = invoicesViewModel.Title;
                invoice.Description = invoicesViewModel.Description;

                var dbTaker = await _takerRepository.GetByCI(invoicesViewModel.Taker.CI);

                if (dbTaker != null)
                {
                    invoice.Taker = dbTaker;
                }

                else
                {
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
                        }
                    };
                }

                invoice.ServiceType = await _serviceTypeRepository.GetByName(invoicesViewModel.ServiceType);
                invoice.TotalValue = invoicesViewModel.Price;
                invoice.TaxValue = 2.5M;

                await _invoiceRepository.Create(invoice);

                //The viewModel is refilled again to redirect to the invoice read-only/printing view.
                invoicesViewModel.Provider = invoice.Provider;
                invoicesViewModel.Taker = invoice.Taker;
                invoicesViewModel.Invoice = invoice;

                return View("Invoice", invoicesViewModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetProviderTotalIncome()
        {
            IEnumerable<Invoice> invoices = await _invoiceRepository.GetByProvider(_loginStorage.GetProvider().Id);
            decimal income = invoices.Sum(x => x.TotalValue);

            return Json(income);
        }
    }
}