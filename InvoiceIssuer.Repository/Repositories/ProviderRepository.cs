using System.Linq;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoiceIssuer.Repository.Repositories
{
    public class ProviderRepository : BaseRepository<Provider>, IProviderRepository
    {
        public ProviderRepository(AppDbContext context) : base(context) { }
        public async Task<Provider> GetByCI(int CI) => await _context.Providers.SingleOrDefaultAsync(x => x.CI.Equals(CI));
    }
}