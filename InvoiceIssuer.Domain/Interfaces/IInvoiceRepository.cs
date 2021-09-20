using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces
{
    public interface IInvoiceRepository : IBaseRepository<Invoice>
    {
        Task<IEnumerable<Invoice>> GetByProvider(Guid Id);
    }
}