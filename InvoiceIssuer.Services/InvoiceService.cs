using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;
using InvoiceIssuer.Services.Sessions;

namespace InvoiceIssuer.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IProviderRepository _providerRepository;
        private readonly ITakerRepository _takerRepository;
        private readonly IServiceTypeRepository _serviceTypeRepository;
        private readonly ICompanyTypeRepository _companyTypeRepository;
        private readonly LoginStorage _loginStorage;

        public InvoiceService(IInvoiceRepository invoiceRepository,
                            IProviderRepository providerRepository,
                            ITakerRepository takerRepository,
                            IServiceTypeRepository serviceTypeRepository,
                            ICompanyTypeRepository companyTypeRepository,
                            LoginStorage loginStorage)
        {
            _invoiceRepository = invoiceRepository;
            _providerRepository = providerRepository;
            _takerRepository = takerRepository;
            _serviceTypeRepository = serviceTypeRepository;
            _companyTypeRepository = companyTypeRepository;
            _loginStorage = loginStorage;
        }
        public async Task<IEnumerable<Invoice>> GetInvoicesByProvider(Guid id)
        {
            return await _invoiceRepository.GetByProvider(id);
        }

        public async Task<Invoice> CreateInvoice(Invoice invoice, Taker taker, Address address)
        {
            Invoice _invoice = new Invoice();
            _invoice = invoice;
            var invoices = await _invoiceRepository.GetByProvider(_loginStorage.GetProvider().Id);
            _invoice.Number = invoices.Where(x => x.Date.Year.Equals(DateTime.UtcNow.Year)).Count() + 1;

            _invoice.Provider = await _providerRepository.GetByCI(_loginStorage.GetProvider().CI);
            var dbTaker = await _takerRepository.GetByCI(taker.CI);
            if (dbTaker != null)
            {
                _invoice.Taker = dbTaker;
            }

            else
            {
                _invoice.Taker = new Taker()
                {
                    Id = Guid.NewGuid(),
                    CreatedAt = DateTime.UtcNow,
                    CI = taker.CI,
                    ComercialName = taker.ComercialName,
                    Phone = taker.Phone,
                    Email = taker.Email,

                    //Get company type name by searching the string of viewModel
                    CompanyType = await _companyTypeRepository.GetByName(taker.CompanyType.Name),
                    Address = new Address()
                    {
                        Id = Guid.NewGuid(),
                        CreatedAt = DateTime.UtcNow,
                        Road = address.Road,
                        Number = address.Number,
                        Complement = address.Complement,
                        Block = address.Block,
                        City = address.City,
                        State = address.State,
                        PostalCode = address.PostalCode
                    }
                };
            }
            _invoice.ServiceType = await _serviceTypeRepository.GetByName(invoice.ServiceType.Name);
            _invoice.TaxValue = 2.5M;
            await _invoiceRepository.Create(_invoice);

            return invoice;
        }

        public async Task<Invoice> ReadInvoice(Guid id)
        {
            return await _invoiceRepository.Read(id);
        }

        public Task<Invoice> UpdateInvoice(Invoice invoice, Taker taker, Address address)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteInvoice(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}