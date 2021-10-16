using System.Linq;
using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace InvoiceIssuer.Repository.Repositories
{
    public class ServiceTypeRepository : BaseRepository<ServiceType>, IServiceTypeRepository
    {
        public ServiceTypeRepository(AppDbContext context) : base(context) { }

        public async Task<ServiceType> GetByName(string name) => await _context.ServiceTypes
            .Where(service => service.Name.Equals(name))
            .FirstOrDefaultAsync(); 
    }
}