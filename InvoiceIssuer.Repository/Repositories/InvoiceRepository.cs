using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoiceIssuer.Repository.Repositories
{
    public class InvoiceRepository : BaseRepository<Invoice>, IInvoiceRepository
    {
        public InvoiceRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Invoice>> GetByProvider(Guid Id) => await _context.Invoices.Where(x => x.ProviderId.Equals(Id)).ToListAsync();
    }
}