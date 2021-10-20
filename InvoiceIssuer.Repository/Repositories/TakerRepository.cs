using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoiceIssuer.Repository.Repositories
{
    public class TakerRepository : BaseRepository<Taker>, ITakerRepository
    {
        public TakerRepository(AppDbContext context) : base(context) { }
        public async Task<Taker> GetByCI(string CI) => await _context.Takers.SingleOrDefaultAsync(x => x.CI.Equals(CI));
    }
}