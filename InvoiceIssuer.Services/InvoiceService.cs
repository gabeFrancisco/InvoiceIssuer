using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Domain.Interfaces.ServicesInterfaces;

namespace InvoiceIssuer.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly IProviderRepository _providerRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository,
                            IProviderRepository providerRepository)
        {
            _invoiceRepository = invoiceRepository;
            _providerRepository = providerRepository;
        }
        public async Task<IEnumerable<Invoice>> GetInvoicesByProvider(Guid id)
        {
            return await _invoiceRepository.GetByProvider(id);
        }
        public Task<Invoice> CreateInvoice(Invoice invoice)
        {
            return null;
        }
    }
}