using System.Linq;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoiceIssuer.Repository.Repositories
{
    public class CompanyTypeRepository : BaseRepository<CompanyType>, ICompanyTypeRepository
    {
        public CompanyTypeRepository(AppDbContext context) : base(context) { }

        public async Task<CompanyType> GetByName(string name) => await _context.CompanyTypes
            .Where(x => x.Name.Equals(name))
            .FirstOrDefaultAsync();
    }
}