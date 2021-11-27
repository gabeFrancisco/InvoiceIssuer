using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces.ServicesInterfaces
{
    public interface IInvoiceService
    {
        Task<IEnumerable<Invoice>> GetInvoicesByProvider(Guid id);
        Task<Invoice> CreateInvoice(Invoice invoice, Taker taker, Address address);
        Task<Invoice> ReadInvoice(Guid id);
        Task<Invoice> UpdateInvoice(Invoice invoice, Taker taker, Address address);
        Task<bool> DeleteInvoice(Guid id);
        Task<IEnumerable<Invoice>> GetAll();
        Task<List<int>> GetInvoiceMonths();
    }
}