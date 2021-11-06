using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces.ServicesInterfaces
{
    public interface IInvoiceService
    {
        Task<IEnumerable<Invoice>> GetInvoicesByProvider(Guid id);
        Task<Invoice> CreateInvoice(Invoice invoice);
    }
}