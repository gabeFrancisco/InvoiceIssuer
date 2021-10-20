using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces
{
    public interface ITakerRepository : IBaseRepository<Taker>
    {
        Task<Taker> GetByCI(string CI);
    }
}