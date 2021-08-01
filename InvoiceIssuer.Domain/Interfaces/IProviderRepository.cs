using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces
{
    public interface IProviderRepository : IBaseRepository<Provider>
    {
        Task<Provider> GetByCI(int CI);
    }
}