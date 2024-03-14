using System.Threading.Tasks;
using InvoiceIssuer.Domain.Entities;

namespace InvoiceIssuer.Domain.Interfaces.ServicesInterfaces
{
    public interface ITakerService
    {
        Task<Taker> ReadTaker(string companyIndex);
    }
}