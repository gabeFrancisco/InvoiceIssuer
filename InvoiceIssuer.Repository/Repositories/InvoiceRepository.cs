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
        
        // public new async Task<Invoice> Read(Guid id) => await _context.Set<Invoice>()
        //     .Where(x => x.Id.Equals(id))
        //     .Include(x => x.Taker)
        //     .Include(x => x.Taker.Address)
        //     .SingleOrDefaultAsync();

        public async Task<IEnumerable<Invoice>> GetByProvider(Guid Id) => await _context.Invoices.Where(x => x.ProviderId.Equals(Id)).ToListAsync();
        // public new async Task<Invoice> Update(Invoice invoice){
            

        //     _context.Set<Invoice>().Update(invoice);
        //     await _context.SaveChangesAsync();

        //     return invoice;
        // }
    }
}