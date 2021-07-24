using InvoiceIssuer.Domain.Entities;
using InvoiceIssuer.Domain.Interfaces;
using InvoiceIssuer.Repository.Context;

namespace InvoiceIssuer.Repository.Repositories
{
    public class ServiceTypeRepository : BaseRepository<ServiceType>, IServiceTypeRepository
    {
        public ServiceTypeRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}