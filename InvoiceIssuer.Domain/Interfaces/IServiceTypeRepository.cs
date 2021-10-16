using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces
{
    public interface IServiceTypeRepository : IBaseRepository<ServiceType>
    {
        Task<ServiceType> GetByName(string name);
    }
}